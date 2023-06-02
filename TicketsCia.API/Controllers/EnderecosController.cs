using Microsoft.AspNetCore.Mvc;
using TicketsCia.API.Repositories;
using TicketsCia.Models;

namespace TicketsCia.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly IEnderecoRepository _objEnderecoRepository;

        public EnderecosController(IEnderecoRepository objEnderecoRepository)
        {
            _objEnderecoRepository = objEnderecoRepository;
        }

        [HttpGet]
        [Route("ObterListaEnderecos")]
        public IActionResult Get()
        {
            var objListaEnderecos = _objEnderecoRepository.Get();
            return Ok(objListaEnderecos);
        }

        [HttpGet]
        [Route("ListarEndereco/{intIdEndereco}")]
        public IActionResult Get(int intIdEndereco)
        {
            var endereco = _objEnderecoRepository.Get(intIdEndereco);
            if (endereco == null)
                return NotFound("Endereco não encontrado!");

            return Ok(endereco);
        }

        [HttpPost]
        [Route("AdicionarEndereco")]
        public IActionResult Add([FromBody] Endereco endereco)
        {
            _objEnderecoRepository.Add(endereco);
            return Ok(endereco);
        }

        [HttpPut]
        [Route("AtualizarEndereco")]
        public IActionResult Update([FromBody] Endereco endereco, int intIdEndereco)
        {
            _objEnderecoRepository.Update(endereco);
            return Ok(endereco);
        }

        [HttpDelete]
        [Route("ExcluirEndereco/{intIdEndereco}")]
        public IActionResult Delete(int intIdEndereco)
        {
            _objEnderecoRepository.Delete(intIdEndereco);
            return Ok();
        }
    }
}
