using BibliotecaAPI.Entities;
using BibliotecaAPI.Model;
using BibliotecaAPI.Persistência;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;
        public LivrosController(BibliotecaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll(string search = "")
        {
            var livros = _context.Livros.Where(l => !l.EstaDeletado).ToList();
            var model = livros.Select(l => LivroViewModel.FromEntity(l)).ToList();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            var model = LivroViewModel.FromEntity(livro);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post(CriadoLivroInputModel model)
        {
            var livro = model.ToEntity();

            _context.Livros.Add(livro);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = livro.Id }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, AtualizadoLivroInputModel model)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            livro.Atualizacao(model.TitulodoLivro, model.AutordoLivro,model.EstilodoLivro, model.Ativo);

            _context.Livros.Update(livro);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            livro.DefinirComoExcluido();
            _context.SaveChanges();
            _context.Livros.Update(livro);
            return NoContent();
        }

        [HttpPost("{id}/comentario")]
        public IActionResult PostComentario(int id, CriadoComentarioLivroInputModel model)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if(livro is null)
            {
                return NotFound();
            }

            var comentario = new ComentarioLivro (model.Comentario, model.IdLivro, model.IdUser);

            _context.ComentariosLivros.Add(comentario);
            _context.SaveChanges();

            return Ok();
        
        }

        [HttpPut("{id}/livre")]
        public IActionResult Livre(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            livro.Livre();
            _context.Livros.Update(livro);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}/perdido")]
        public IActionResult Perdido(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            livro.Perdido();
            _context.Livros.Update(livro);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}/emprestado")]
        public IActionResult Emprestado(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);

            if (livro is null)
            {
                return NotFound();
            }

            livro.Emprestado();
            _context.Livros.Update(livro);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
