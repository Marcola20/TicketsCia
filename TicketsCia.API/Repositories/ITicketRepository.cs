using TicketsCia.Models;
namespace TicketsCia.API.Repositories
{
    public interface ITicketRepository
    {
        List<Ticket> Get();

        Ticket Get(int intIdIngresso);

        void Add(Ticket ticket);

        void Update(Ticket ticket);

        void Delete(int intIdIngresso);

    }
}
