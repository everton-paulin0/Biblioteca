using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Model
{
    public class AtualizadoLivroInputModel
    {
        
        public AtualizadoLivroInputModel(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo, LivroSituacaoEnum situacao, List<string> comentarios, List<string> usuarios)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
            Situacao = situacao;
            Comentarios = comentarios;
            Usuarios = usuarios;
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        public List<string> Comentarios { get; set; }
        public List<string> Usuarios { get; set; }

    }
}
