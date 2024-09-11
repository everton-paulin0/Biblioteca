
using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Entities
{
    public class Livro : EntidadeBase
    {
        public Livro()
        {
            
        }
        public Livro(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo, int idUsuario, string nomeUsuario) :base()
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            IdUsuario = idUsuario;
            Ativo = true;

            Situacao = LivroSituacaoEnum.Livre;
            Comentarios = [];
        }

        public Livro(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo, int idUsuario)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
            IdUsuario = idUsuario;
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        public int IdUsuario { get; set; }      
        public Usuario Usuario { get; set; }
        public List<ComentarioLivro> Comentarios { get; set; }

        public List<Usuario> ListaUsuario { get; set; }
        

        public void Atualizacao (string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;

            Comentarios = [];
            ListaUsuario = [];

        }

        public void Livre()
        {
            if (Situacao != LivroSituacaoEnum.Livre)
            {
                Situacao = LivroSituacaoEnum.Livre;
                AtualizadoEm = DateTime.Now;
            }
        }

        public void Perdido()
        {
            if (Situacao != LivroSituacaoEnum.Perdido)
            {
                Situacao = LivroSituacaoEnum.Perdido;
                AtualizadoEm = DateTime.Now;
            }
        }

        public void Emprestado()
        {
            if (Situacao != LivroSituacaoEnum.Emprestado)
            {
                Situacao = LivroSituacaoEnum.Emprestado;
                AtualizadoEm = DateTime.Now;
            }
        }
    }
}
