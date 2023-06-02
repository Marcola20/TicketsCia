namespace TicketsCia.API.Repositories
{
    public interface IEnderecoRepository
    {
        List<Endereco> Get();

        Endereco Get(int intIdEndereco);

        public void Add(Endereco endereco);

        public void Update(Endereco endereco);

        void Delete(int intIdEndereco);
    }
}
