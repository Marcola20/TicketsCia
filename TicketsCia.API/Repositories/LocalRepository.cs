using TicketsCia.API.Database;
using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public class LocalRepository : ILocalRepository
    {
        private readonly TicketsCiaContext _db;

        public LocalRepository(TicketsCiaContext db)
        {
            _db = db;
        }

        public List<Local> Get()
        {
            return _db.Locais.OrderBy(a => a.LocalId).ToList();
        }

        public Local Get(int intIdLocal)
        {
            // O Entity Framework já sabe qual é a chave primária, por isso não preciso indicar o ID
            return _db.Locais.Find(intIdLocal)!;
        }

        public void Add(Local local)
        {
            // UOW - Unit of Works
            _db.Locais.Add(local);
            _db.SaveChanges();  // O Save Changes é como se fosse o commit para o Banco de Dados
        }
        public void Update(Local local)
        {
            _db.Locais.Update(local);
            _db.SaveChanges();
        }

        public void Delete(int intIdLocal)
        {
            _db.Locais.Remove(Get(intIdLocal));
            _db.SaveChanges();
        }

    }
}
