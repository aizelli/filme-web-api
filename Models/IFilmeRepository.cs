namespace filme_web_api.Models
{
    public interface IFilmeRepository
    {
        void Add(Filme filme);

        List<Filme> GetAll();
    }
}
