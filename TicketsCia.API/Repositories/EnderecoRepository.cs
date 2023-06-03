using TicketsCia.API.Database;
using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly TicketsCiaContext _db;

        public EnderecoRepository(TicketsCiaContext db)
        {
            _db = db;
        }

        public List<Endereco> Get()
        {
            return _db.Enderecos.OrderBy(a => a.EnderecoId).ToList();
        }

        public Endereco Get(int intIdEndereco)
        {
            // O Entity Framework já sabe qual é a chave primária, por isso não preciso indicar o ID
            return _db.Enderecos.Find(intIdEndereco)!;
        }

        public void Add(Endereco endereco)
        {
            // UOW - Unit of Works
            _db.Enderecos.Add(endereco);
            _db.SaveChanges();  // O Save Changes é como se fosse o commit para o Banco de Dados
        }
        public void Update(Endereco endereco)
        {
            _db.Enderecos.Update(endereco);
            _db.SaveChanges();
        }

        public void Delete(int intIdEndereco)
        {
            _db.Enderecos.Remove(Get(intIdEndereco));
            _db.SaveChanges();
        }

    }
}
