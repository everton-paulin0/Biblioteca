namespace BibliotecaAPI.Entities
{
    public class Usuario : EntidadeBase
    {
        public Usuario()
        {

        }
        public Usuario(string nomeCompleto, string email, string telefone)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Telefone = telefone;
            

            Livros = [];
            Comentarios = [];
        }

        
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Livro> Livros { get; set; }

        public List<ComentarioLivro> Comentarios { get; set; }

        

    }
}
