namespace BibliotecaAPI.Entities
{
    public class ComentarioLivro : EntidadeBase
    {
        public ComentarioLivro()
        {
            
        }
        public ComentarioLivro(string comentario, int idLivro, Livro livro) :base()
        {
            Comentario = comentario;
            IdLivro = idLivro;
          
        }

        public string Comentario { get; set; }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
    }
}
