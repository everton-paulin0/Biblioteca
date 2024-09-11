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
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Livro>(e=>
            {
                e.HasKey(e => e.Id);
                
                e.HasOne(l=> l.Usuario)
                .WithMany(l=> l.Livros)
                .HasForeignKey(l=> l.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            });

            builder.Entity<ComentarioLivro>(e =>
            {
                e.HasKey(c => c.Id);

                e.HasOne(c => c.Livro)
                .WithMany(c => c.Comentarios)
                .HasForeignKey(c => c.IdLivro)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(c => c.Usuarios)
                .WithMany(c => c.Comentarios)
                .HasForeignKey(c => c.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);
                
            });

            builder.Entity<Usuario>(e =>
            {
                e.HasKey(e => e.Id);

                e.HasMany(u => u.Livros)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);
                
     
            });
           
            base.OnModelCreating(builder);

            
        }
    }
}
