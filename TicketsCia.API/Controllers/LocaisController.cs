using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TicketsCia.API.Repositories;
using TicketsCia.Models;

namespace TicketsCia.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]/")]
    [ApiController]
    public class LocaisController : ControllerBase
    {
        private readonly ILocalRepository _objLocalRepository;

        public LocaisController(ILocalRepository objLocalRepository)
        {
            _objLocalRepository = objLocalRepository;
        }

        [HttpGet]
        [Route("ObterListaLocais")]
        public IActionResult Get()
        {
            var objListaLocais = _objLocalRepository.Get();
            return Ok(objListaLocais);
        }

        [HttpGet]
        [Route("ListarLocal/{intIdLocal}")]
        public IActionResult Get(int intIdLocal)
        {
            var local = _objLocalRepository.Get(intIdLocal);
            if (local == null)
                return NotFound("Local não encontrado!");

            return Ok(local);
        }

        [HttpPost]
        [Route("AdicionarLocal")]
        public IActionResult Add([FromBody] Local local)
        {
            _objLocalRepository.Add(local);
            return Ok(local);
        }

        [HttpPut]
        [Route("AtualizarLocal")]
        public IActionResult Update([FromBody] Local local, int intIdLocal)
        {
            _objLocalRepository.Update(local);
            return Ok(local);
        }

        [HttpDelete]
        [Route("ExcluirCategoria/{intIdLocal}")]
        public IActionResult Delete(int intIdLocal)
        {
            _objLocalRepository.Delete(intIdLocal);
            return Ok();
        }
    }
}
