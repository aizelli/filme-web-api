using filme_web_api.Models;

namespace filme_web_api.DataBase
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Filme filme)
        {
            _context.filmes.Add(filme);
            _context.SaveChanges();
        }

        public List<Filme> GetAll()
        {
            return _context.filmes.ToList();
        }
    }
}
