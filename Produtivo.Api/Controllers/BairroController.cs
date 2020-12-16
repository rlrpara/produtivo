using Microsoft.AspNetCore.Mvc;
using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using System;

namespace Produtivo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BairroController : ControllerBase
    {
        private readonly IBairroRepositorio _bairroRepositorio;

        public BairroController(IBairroRepositorio bairroRepositorio)
        {
            _bairroRepositorio = bairroRepositorio;
        }

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

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Bairro bairro)
        {
            try
            {
                Bairro bairoRepositorio = _bairroRepositorio.ObterPorId(id);
                if (bairoRepositorio == null)
                    return NotFound();

                _bairroRepositorio.Atualizar(bairoRepositorio);
                return Ok(bairoRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Bairro bairro)
        {
            try
            {
               Bairro bairroRepositorio = _bairroRepositorio.ObterPorId(id);
                if (bairroRepositorio == null)
                    return NotFound();

                _bairroRepositorio.Remover(bairroRepositorio);
                return Ok(bairroRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
