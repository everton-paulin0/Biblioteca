using BibliotecaAPI.Entities;

namespace BibliotecaAPI.Model
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nomeCompleto, string email, string telefone, string livroId)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Telefone = telefone;
            LivroId = livroId;
        }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string LivroId { get; set; }

        public static UsuarioViewModel FromEntity(Usuario usuario)
        {
            return new UsuarioViewModel(usuario.NomeCompleto, usuario.Email, usuario.Telefone, usuario.LivroId);
        }
    }
}
