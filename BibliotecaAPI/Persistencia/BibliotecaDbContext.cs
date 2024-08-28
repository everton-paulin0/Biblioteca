using BibliotecaAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Persistência
{
    public class BibliotecaDbContext :DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) :base(options)
        {
            
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Livro>(e=>
            {
                e.HasKey(e => e.Id);

            });

            base.OnModelCreating(builder);
        }
    }
}
