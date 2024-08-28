
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
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }
        public bool Ativo { get; set; }

        
        public void Atualizacao (string titulodoLivro, string autordoLivro, string estilodoLivro)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
        }
    }
}
