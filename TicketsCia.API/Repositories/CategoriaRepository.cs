using System.Net.Sockets;
using TicketsCia.API.Database;
using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly TicketsCiaContext _db;

        public CategoriaRepository(TicketsCiaContext db)
        {
            _db = db;
        }

        public List<Categoria> Get()
        {
            return _db.Categorias.OrderBy(a => a.CategoriaId).ToList();
        }

        public Categoria Get(int intIdCategoria)
        {
            // O Entity Framework já sabe qual é a chave primária, por isso não preciso indicar o ID
            return _db.Categorias.Find(intIdCategoria)!;
        }

        public void Add(Categoria categoria)
        {
            // UOW - Unit of Works
            _db.Categorias.Add(categoria);
            _db.SaveChanges();  // O Save Changes é como se fosse o commit para o Banco de Dados
        }
        public void Update(Categoria categoria)
        {
            _db.Categorias.Update(categoria);
            _db.SaveChanges();
        }

        public void Delete(int intIdCategoria)
        {
            _db.Categorias.Remove(Get(intIdCategoria));
            _db.SaveChanges();
        }

    }
}
