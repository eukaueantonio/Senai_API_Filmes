using API_Filmes_SENAI.Domains;
using API_Filmes_SENAI.Interfaces;
using API_Filmes_SENAI.NovaPasta;
using API_Filmes_SENAI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Filmes_SENAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [Authorize]
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201, usuario);

            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        //BuscarPorId
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id) 
        {
            try
            {
                Usuario usuario = _usuarioRepository.BuscarPorId(id);
                if (usuario != null)
                {
                    return Ok(usuario);
                }
                return null!;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        
        }

    }
}
