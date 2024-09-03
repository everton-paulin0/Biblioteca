namespace BibliotecaAPI.Entities
{
    public abstract class EntidadeBase
    {
        protected EntidadeBase()
        {
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            EstaDeletado = false;
        }
        public int Id { get; private set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public bool EstaDeletado { get; private set; }

        public void DefinirComoExcluido()
        { 
            EstaDeletado = true;
        }
    }
}
