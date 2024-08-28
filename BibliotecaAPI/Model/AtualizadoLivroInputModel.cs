namespace BibliotecaAPI.Model
{
    public class AtualizadoLivroInputModel
    {
        public AtualizadoLivroInputModel(string titulodoLivro, string autordoLivro, string estilodoLivro)
        {
            TitulodoLivro = titulodoLivro;
            AutordoLivro = autordoLivro;
            EstilodoLivro = estilodoLivro;
        }

        public string TitulodoLivro { get; set; }
        public string AutordoLivro { get; set; }
        public string EstilodoLivro { get; set; }

    }
}
