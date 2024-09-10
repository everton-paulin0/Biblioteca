using BibliotecaAPI.Entities;
using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Model
{
    public class LivroViewModel
    {
        public LivroViewModel()
        {
            
        }
        public LivroViewModel(int id, string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo, List<ComentarioLivro> comentarios, int idUsuario)
        {
            Id = id;
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
            IdUsuario = idUsuario;
            //Comentarios = comentarios.Select(c => c.Comentario).ToList();
        }

        public int Id { get; set; }
        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public int IdUsuario { get; set; }
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        public List<string> Comentarios { get; set; }
        public static LivroViewModel FromEntity(Livro livro) => new LivroViewModel(livro.Id, livro.TitulodoLivro, livro.AutordoLivro, livro.EstilodoLivro, livro.Ativo,livro.Comentarios, livro.IdUsuario);
    }
}
