
using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Entities
{
    public class Livro : EntidadeBase
    {
        public Livro()
        {
            
        }
        public Livro(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;

            Situacao = LivroSituacaoEnum.Livre;
            Comentarios = [];
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        public List<ComentarioLivro> Comentarios { get; set; }


        public void Atualizacao (string titulodoLivro, string autordoLivro, string estilodoLivro)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
        }

        public void Livre()
        {
            if (Situacao == LivroSituacaoEnum.Livre)
            {
                AtualizadoEm = DateTime.Now;
            }
        }

        public void Perdido()
        {
            if (Situacao == LivroSituacaoEnum.Perdido)
            {
                AtualizadoEm = DateTime.Now;
            }
        }

        public void Emprestado()
        {
            if (Situacao == LivroSituacaoEnum.Emprestado)
            {
                AtualizadoEm = DateTime.Now;
            }
        }
    }
}
