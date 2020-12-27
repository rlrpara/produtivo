using Microsoft.AspNetCore.Mvc;
using Produtivo.Domain.Interface;
using Produtivo.Domain.Entities;
using System;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepository.Add(usuario);
                    return Created("api/usuario", usuario);
                }

                return BadRequest("Classe inválida");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        [Authorize]
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
        [Authorize]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_usuarioRepository.Get(id) == null) return NotFound();

                    _usuarioRepository.Update(usuario);

                    return Ok(_usuarioRepository.Get(id));
                }

                return BadRequest("Classe inválida");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
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
