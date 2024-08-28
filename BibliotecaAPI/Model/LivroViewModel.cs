using BibliotecaAPI.Entities;

namespace BibliotecaAPI.Model
{
    public class LivroViewModel
    {
        public LivroViewModel()
        {
            
        }
        public LivroViewModel(int id, string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo)
        {
            Id = id;
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
        }

        public int Id { get; set; }
        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }
        public static LivroViewModel FromEntiity(Livro livro) => new LivroViewModel(livro.Id, livro.TitulodoLivro, livro.AutordoLivro, livro.EstilodoLivro, livro.Ativo);
    }
}
