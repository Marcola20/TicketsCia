using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TicketsCia.API.Repositories;
using TicketsCia.Models;

namespace TicketsCia.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]/")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _objCategoriaRepository;

        public CategoriasController(ICategoriaRepository objCategoriaRepository)
        {
            _objCategoriaRepository = objCategoriaRepository;
        }

        [HttpGet]
        [Route("ObterListaCategorias")]
        public IActionResult Get()
        {
            var objListaCategorias = _objCategoriaRepository.Get();
            return Ok(objListaCategorias);
        }

        [HttpGet]
        [Route("ListarCategoria/{intIdCategoria}")]
        public IActionResult Get(int intIdCategoria)
        {
            var categoria = _objCategoriaRepository.Get(intIdCategoria);
            if (categoria == null)
                return NotFound("Categoria não encontrada!");

            return Ok(categoria);
        }

        [HttpPost]
        [Route("AdicionarCategoria")]
        public IActionResult Add([FromBody] Categoria categoria)
        {
            _objCategoriaRepository.Add(categoria);
            return Ok(categoria);
        }

        [HttpPut]
        [Route("AtualizarCategoria")]
        public IActionResult Update([FromBody] Categoria categoria, int intIdCategoria)
        {
            _objCategoriaRepository.Update(categoria);
            return Ok(categoria);
        }

        [HttpDelete]
        [Route("ExcluirCategoria/{intIdCategoria}")]
        public IActionResult Delete(int intIdCategoria)
        {
            _objCategoriaRepository.Delete(intIdCategoria);
            return Ok();
        }
    }
}
