namespace BibliotecaAPI.Model
{
    public class CriadoComentarioLivroInputModel
    {
        public string Comentario { get; set; }
        public int IdLivro { get; set; }
        public int IdUser { get; set; }

    }
}
