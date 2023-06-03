using Microsoft.AspNetCore.Mvc;
using System.Data;
using TicketsCia.API.Repositories;
using TicketsCia.Models;

namespace TicketsCia.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _objUsuarioRepository;

        public UsuariosController(IUsuarioRepository objUsuarioRepository)
        {
            _objUsuarioRepository = objUsuarioRepository;
        }

        [HttpGet]
        [Route("ObterListaUsuarios")]
        public IActionResult Get()
        {
            var objListaUsuarios = _objUsuarioRepository.Get();
            return Ok(objListaUsuarios);
        }

        [HttpGet]
        [Route("ListarUsuario/{intIdUsuario}")]
        public IActionResult Get(int intIdUsuario)
        {
            var usuario = _objUsuarioRepository.Get(intIdUsuario);
            if (usuario == null)
                return NotFound("Usuario não encontrado!");

            return Ok(usuario);
        }

        [HttpPost]
        [Route("AdicionarUsuario")]
        public IActionResult Add([FromBody] Usuario usuario)
        {
            _objUsuarioRepository.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut]
        [Route("AtualizarUsuario")]
        public IActionResult Update([FromBody] Usuario usuario, int intIdUsuario)
        {
            _objUsuarioRepository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete]
        [Route("ExcluirUsuario/{intIdUsuario}")]
        public IActionResult Delete(int intIdUsuario)
        {
            _objUsuarioRepository.Delete(intIdUsuario);
            return Ok();
        }

    }
}
