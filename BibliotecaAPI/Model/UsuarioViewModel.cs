using BibliotecaAPI.Entities;

namespace BibliotecaAPI.Model
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nomeCompleto, string email, string telefone)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Telefone = telefone;
        }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public static UsuarioViewModel FromEntity(Usuario usuario)
        {
            return new UsuarioViewModel(usuario.NomeCompleto, usuario.Email, usuario.Telefone);
        }
    }
}
