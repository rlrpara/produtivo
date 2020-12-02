using Microsoft.AspNetCore.Mvc;
using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Produtivo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BairroController : Controller
    {
        private readonly IBairroRepositorio _bairroRepositorio;

        public BairroController(IBairroRepositorio bairroRepositorio)
        {
            _bairroRepositorio = bairroRepositorio;
        }

        // GET: api/<BairroController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_bairroRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET api/<BairroController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_bairroRepositorio.ObterPorId(id));
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.ToString());
            }
        }

        // POST api/<BairroController>
        [HttpPost]
        public IActionResult Post([FromBody] Bairro bairro)
        {
            try
            {
                _bairroRepositorio.Adicionar(bairro);
                return Created("api/bairro", bairro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<BairroController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Bairro bairro)
        {
            try
            {
                _bairroRepositorio.ObterPorId(id);
                if (_bairroRepositorio.ObterPorId(id) == null)
                    return NotFound();

                _bairroRepositorio.Atualizar(bairro);
                return Ok(bairro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<BairroController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Bairro bairro)
        {
            try
            {
                _bairroRepositorio.ObterPorId(id);
                if (_bairroRepositorio.ObterPorId(id) == null)
                    return NotFound();

                _bairroRepositorio.Remover(bairro);
                return Ok(bairro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
