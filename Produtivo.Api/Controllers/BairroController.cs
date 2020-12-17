using Microsoft.AspNetCore.Mvc;
using Produtivo.Domain.Interface;
using Produtivo.Domain.Entities;
using System;

namespace Produtivo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BairroController : ControllerBase
    {
        private readonly IBairroRepository _bairroRepositorio;

        public BairroController(IBairroRepository bairroRepositorio)
        {
            _bairroRepositorio = bairroRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_bairroRepositorio.GetAll());
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
                return Ok(_bairroRepositorio.Get(id));
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
                _bairroRepositorio.Add(bairro);
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
                Bairro bairoRepositorio = _bairroRepositorio.Get(id);
                if (bairoRepositorio == null)
                    return NotFound();

                _bairroRepositorio.Update(bairoRepositorio);
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
               Bairro bairroRepositorio = _bairroRepositorio.Get(id);
                if (bairroRepositorio == null)
                    return NotFound();

                _bairroRepositorio.Remove(bairroRepositorio);
                return Ok(bairroRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
