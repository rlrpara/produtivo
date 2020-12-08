using Microsoft.AspNetCore.Mvc;
using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using System;

namespace Produtivo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id)")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_usuarioRepositorio.ObterPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Adicionar(usuario);
                return Created("api/usuario", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            try
            {
                Usuario usuarioRepositorio = _usuarioRepositorio.ObterPorId(id);

                if (usuarioRepositorio == null)
                    return NotFound();

                _usuarioRepositorio.Atualizar(usuarioRepositorio);
                return Ok(usuarioRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Usuario usuarioRepositorio = _usuarioRepositorio.ObterPorId(id);

                if (usuarioRepositorio == null)
                    return NotFound();

                _usuarioRepositorio.Remover(usuarioRepositorio);
                return Ok(usuarioRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
