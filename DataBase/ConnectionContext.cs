using filme_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace filme_web_api.DataBase
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Filme> filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Port=5432;" +
                "Database=Etec;" +
                "Username=postgres;" +
                "Password=123456;"
                );

    }
}
