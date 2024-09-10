namespace BibliotecaAPI.Entities
{
    public class ComentarioLivro : EntidadeBase
    {
        public ComentarioLivro()
        {
            
        }
        public ComentarioLivro(string comentario, int idLivro, int idUsuario) :base()
        {
            Comentario = comentario;
            IdLivro = idLivro;
            IdUsuario = idUsuario;
          
        }

        public string Comentario { get; set; }
        public int IdLivro { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuarios { get; set; }
        public Livro Livro { get; set; }
    }
}
