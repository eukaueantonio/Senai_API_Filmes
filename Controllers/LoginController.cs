using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using API_Filmes_SENAI.Domains;
using API_Filmes_SENAI.DTO;
using API_Filmes_SENAI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace API_Filmes_SENAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        /// <summary>
        /// Endpoint para buscar o token pelo email e senha
        /// </summary>
        /// <param name="loginDTO">Id do Gênero buscado</param>
        /// <returns>Token Buscado</returns>
        [HttpPost]
        public IActionResult Login(LoginDTO loginDTO)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailESenha(loginDTO.Email!, loginDTO.Senha!);

                if (usuarioBuscado == null)
                {
                    return NotFound("Usuario nao encontrado, email ou senha invalidos");
                }

                //Caso o usuario seja encontrado, prossegue para a criacao do token

                //1 passo - definir as claims() que serao fornecidos no token

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email!),
                    new Claim(JwtRegisteredClaimNames.Name, usuarioBuscado.Nome!),

                    //podemos definir uma claim personalizada
                    new Claim("Nome da Claim", "Valor da Claim")
                };

                //2 passo - definir uma chave de acesso do token 
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));

                //3 passo - definir as credencias do token (header)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4 passo - gerar o token
                var token = new JwtSecurityToken
                    (
                        //emissor do token
                        issuer: "api_filmes_senai",

                        //destinatario do token
                        audience: "api_filmes_senai",

                        //dados definidos nas claims 
                        claims: claims,

                        //tempo de expiracao do token
                        expires: DateTime.Now.AddMinutes(5),

                        //credencias do token
                        signingCredentials: creds

                        );
                return Ok(
                    new
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                    }
                    );
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
