using Microsoft.EntityFrameworkCore;

namespace TicketsCia.API.Database
{
    public class TicketsCiaContext : DbContext
    {
        public TicketsCiaContext(DbContextOptions<TicketsCiaContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Local> Locais { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Usuario> Usuarios{ get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        #region Conexão sem distinção de ambientes de execução
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TicketsCia;Integrated Security=True;");
        }
        */
        #endregion
    }
}
