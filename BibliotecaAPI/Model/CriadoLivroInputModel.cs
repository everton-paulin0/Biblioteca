using BibliotecaAPI.Entities;
using BibliotecaAPI.Enum;

namespace BibliotecaAPI.Model
{
    public class CriadoLivroInputModel
    {
        public CriadoLivroInputModel()
        {
            
        }

        public CriadoLivroInputModel(string titulodoLivro, string autordoLivro, string estilodoLivro,bool ativo, LivroSituacaoEnum situacao, int idUsuario)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
            Ativo = ativo;
            Situacao = situacao;
            IdUsuario = idUsuario;
            
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public int IdUsuario { get; set; }
        
        public bool Ativo { get; set; }
        public LivroSituacaoEnum Situacao { get; set; }
        
        public Livro ToEntity() => new(TitulodoLivro, AutordoLivro, EstilodoLivro, Ativo, IdUsuario);
        
    }
}
