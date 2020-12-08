using Microsoft.AspNetCore.Mvc;
using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtivo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaridadeController : ControllerBase
    {
        private readonly IEscolaridadeRepositorio _escolaridadeRepositorio;

        public EscolaridadeController(IEscolaridadeRepositorio escolaridadeRepositorio)
        {
            _escolaridadeRepositorio = escolaridadeRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_escolaridadeRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET api/<EscolaridadeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Escolaridade escolaridadeRepositorio = _escolaridadeRepositorio.ObterPorId(id);

                if (escolaridadeRepositorio == null)
                    return NotFound();

                return Ok(escolaridadeRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<EscolaridadeController>
        [HttpPost]
        public IActionResult Post([FromBody] Escolaridade escolaridade)
        {
            try
            {
                _escolaridadeRepositorio.Adicionar(escolaridade);
                return Created("api/escolaridade", escolaridade);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // PUT api/<EscolaridadeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EscolaridadeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
