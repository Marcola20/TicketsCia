using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketsCia.API.Repositories;
using TicketsCia.Models;

namespace TicketsCia.API.Controllers
{
    //[DisableCors]
    [Route("api/[controller]/")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketRepository _objTicketRepository;

        public TicketsController(ITicketRepository objTicketRepository)
        {
            _objTicketRepository = objTicketRepository;
        }

        [HttpGet]
        [Route("ObterListaIngressos")]
        public IActionResult Get()
        {
            var objListaTickets = _objTicketRepository.Get();
            return Ok(objListaTickets);
        }

        [HttpGet]
        [Route("ListarIngresso/{intIdIngresso}")]
        public IActionResult Get(int intIdIngresso) 
        {
            var ticket = _objTicketRepository.Get(intIdIngresso);
            if (ticket == null)
                return NotFound("Ingresso não encontrado!");
            
            return Ok(ticket);
        }

        [HttpPost]
        [Route("AdicionarIngresso")]
        public IActionResult Add([FromBody]Ticket ticket)
        {
            _objTicketRepository.Add(ticket);
            return Ok(ticket);
        }

        [HttpPut]
        [Route("AtualizarIngresso")]
        public IActionResult Update([FromBody] Ticket ticket, int intIdIngresso)
        {
            _objTicketRepository.Update(ticket);
            return Ok(ticket);
        }

        [HttpDelete]
        [Route("ExcluirIngresso/{intIdIngresso}")]
        public IActionResult Delete(int intIdIngresso)
        {
            _objTicketRepository.Delete(intIdIngresso);
            return Ok();
        }
    }
}
