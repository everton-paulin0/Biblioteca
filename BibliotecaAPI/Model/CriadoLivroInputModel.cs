using BibliotecaAPI.Entities;
using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Model
{
    public class CriadoLivroInputModel
    {
        public CriadoLivroInputModel()
        {
            
        }

        public CriadoLivroInputModel(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo, LivroSituacaoEnum situacao, List<string> comentarios)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
            Situacao = situacao;
            Comentarios = comentarios;
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        public List<string> Comentarios { get; set; }



        public Livro ToEntity() => new(TitulodoLivro, AutordoLivro, EstilodoLivro, Ativo);
        
    }
}
