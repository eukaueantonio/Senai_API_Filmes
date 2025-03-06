using API_Filmes_SENAI.Interfaces;
using API_Filmes_SENAI.NovaPasta;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Filmes_SENAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _generoRepository;
        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        /// <summary>
        /// Endpoint para listar um Gênero pelo seu Id 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_generoRepository.Listar());

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// Endpoint para criar um Gênero 
        /// </summary>
        /// <param name="id">Id do Gênero buscado</param>
        /// <returns>Gênero Buscado</returns>
        [HttpPost]

        public IActionResult Post(Genero novoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(novoGenero);

                return Created();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint para buscar um Gênero pelo seu Id 
        /// </summary>
        /// <param name="id">Id do Gênero buscado</param>
        /// <returns>Gênero Buscado</returns>
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Genero generoBuscado= _generoRepository.BuscarPorId(id);
                return Ok(generoBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint para deletar um Gênero pelo seu Id 
        /// </summary>
        /// <param name="id">Id do Gênero buscado</param>
        /// <returns>Gênero Buscado</returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                _generoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Endpoint para atualizar um Gênero pelo seu Id 
        /// </summary>
        /// <param name="id">Id do Gênero buscado</param>
        /// <param name="genero">Nome do Gênero buscado</param>
        /// <returns>Gênero Buscado</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Genero genero)
        {
            try
            {
                _generoRepository.Atualizar(id, genero);

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
            

    }
}
