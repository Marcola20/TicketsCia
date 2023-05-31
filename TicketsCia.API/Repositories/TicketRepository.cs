using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;
using TicketsCia.API.Database;
using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketsCiaContext _db;

        public TicketRepository(TicketsCiaContext db)
        {
            _db = db;
        }

        public List<Ticket> Get()
        {
            return _db.Tickets.OrderBy(a => a.IngressoId).ToList();
        }

        public Ticket Get(int intIdIngresso)
        {
            // O Entity Framework já sabe qual é a chave primária, por isso não preciso indicar o ID
            return _db.Tickets.Find(intIdIngresso)!;
        }

        public void Add(Ticket ticket)
        {
            // UOW - Unit of Works
            _db.Tickets.Add(ticket);
            _db.SaveChanges();  // O Save Changes é como se fosse o commit para o Banco de Dados
        }

        public void Update(Ticket ticket)
        {
            _db.Tickets.Update(ticket);
            _db.SaveChanges();
        }

        public void Delete(int intIdIngresso)
        {
            _db.Tickets.Remove(Get(intIdIngresso));
            _db.SaveChanges();
        }
    }
}
