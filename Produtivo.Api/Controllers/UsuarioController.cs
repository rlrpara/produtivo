using Microsoft.AspNetCore.Mvc;
using Produtivo.Domain.Interface;
using Produtivo.Domain.Entities;
using System;

namespace Produtivo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepositorio)
        {
            _usuarioRepository = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var usuarios = _usuarioRepository.GetAll();

                return Ok(usuarios);
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
                return Ok(_usuarioRepository.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepository.Add(usuario);
                return Created("api/usuario", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "rlr.para@gmail.com" && usuario.Senha == "123")
                    return Ok(usuario);

                return BadRequest("Usuário ou senha inválidos");
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
                Usuario usuarioRepositorio = _usuarioRepository.Get(id);

                if (usuarioRepositorio == null)
                    return NotFound();

                _usuarioRepository.Update(usuarioRepositorio);
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
                Usuario usuarioRepositorio = _usuarioRepository.Get(id);

                if (usuarioRepositorio == null)
                    return NotFound();

                _usuarioRepository.Remove(usuarioRepositorio);
                return Ok(usuarioRepositorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
