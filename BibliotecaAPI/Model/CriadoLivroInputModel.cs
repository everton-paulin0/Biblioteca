using BibliotecaAPI.Entities;

namespace BibliotecaAPI.Model
{
    public class CriadoLivroInputModel
    {
        public CriadoLivroInputModel(string titulodoLivro, string autordoLivro, string estilodoLivro, bool ativo)
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

        public Livro ToEntity() => new (TitulodoLivro, AutordoLivro, EstilodoLivro, Ativo);
    }
}
