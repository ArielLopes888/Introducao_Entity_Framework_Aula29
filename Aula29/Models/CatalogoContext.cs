using Microsoft.EntityFrameworkCore;

namespace Aula29.Models
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options):base(options)
        {}

        public DbSet<Filme> Moovies { get; set; }
        public DbSet<Ator> Atores { get; set; }
    }
}
