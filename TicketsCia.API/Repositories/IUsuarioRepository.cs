namespace TicketsCia.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();

        Usuario Get(int intIdUsuario);

        public void Add(Usuario usuario);

        public void Update(Usuario usuario);

        void Delete(int intIdUsuario);
    }
}
