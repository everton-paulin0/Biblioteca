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
        public DbSet<ComentarioLivro> ComentariosLivros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Livro>(e=>
            {
                e.HasKey(e => e.Id);

            });

            builder.Entity<ComentarioLivro>(e =>
            {
                e.HasKey(c => c.Id);

                e.HasOne(c => c.Livro)
                .WithMany(c => c.Comentarios)
                .HasForeignKey(c => c.IdLivro)
                .OnDelete(DeleteBehavior.Restrict);

            });

            base.OnModelCreating(builder);

            
        }
    }
}
