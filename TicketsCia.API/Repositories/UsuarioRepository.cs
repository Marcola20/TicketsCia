using TicketsCia.API.Database;
using TicketsCia.Models;

namespace TicketsCia.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly TicketsCiaContext _db;

        public UsuarioRepository(TicketsCiaContext db)
        {
            _db = db;
        }
        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy(a => a.UsuarioId).ToList();
        }

        public Usuario Get(int intIdUsuario)
        {
            // O Entity Framework já sabe qual é a chave primária, por isso não preciso indicar o ID
            return _db.Usuarios.Find(intIdUsuario)!;
        }

        public void Add(Usuario usuario)
        {
            // UOW - Unit of Works
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();  // O Save Changes é como se fosse o commit para o Banco de Dados
        }
        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }

        public void Delete(int intIdUsuario)
        {
            _db.Usuarios.Remove(Get(intIdUsuario));
            _db.SaveChanges();
        }

    }
}
