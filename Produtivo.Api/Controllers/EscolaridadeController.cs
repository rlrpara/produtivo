using Microsoft.AspNetCore.Mvc;
using Produtivo.Domain.Interface;
using Produtivo.Domain.Entities;
using System;

namespace Produtivo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EscolaridadeController : ControllerBase
    {
        private readonly IEscolaridadeRepository _escolaridadeRepositorio;

        public EscolaridadeController(IEscolaridadeRepository escolaridadeRepositorio)
        {
            _escolaridadeRepositorio = escolaridadeRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_escolaridadeRepositorio.GetAll());
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
                Escolaridade escolaridadeRepositorio = _escolaridadeRepositorio.Get(id);

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
                _escolaridadeRepositorio.Add(escolaridade);
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
