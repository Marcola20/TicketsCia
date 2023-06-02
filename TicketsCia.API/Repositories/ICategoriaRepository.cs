using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public interface ICategoriaRepository
    {
        List<Categoria> Get();

        Categoria Get(int intIdCategoria);

        public void Add(Categoria categoria);

        public void Update(Categoria categoria);

        void Delete(int intIdCategoria);
    }
}
