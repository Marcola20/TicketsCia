namespace TicketsCia.API.Repositories
{
    public interface ILocalRepository
    {
        List<Local> Get();

        Local Get(int intIdLocal);

        public void Add(Local local);

        public void Update(Local local);

        void Delete(int intIdLocal);
    }
}
