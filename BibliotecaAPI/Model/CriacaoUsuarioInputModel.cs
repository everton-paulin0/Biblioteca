using BibliotecaAPI.Entities;

namespace BibliotecaAPI.Model
{
    public class CriacaoUsuarioInputModel
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string telefone { get; set; }
        public string LivroId { get; set; }
        //public Livro Livros { get; set; }
    }
}
