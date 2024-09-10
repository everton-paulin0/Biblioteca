using BibliotecaAPI.Entities;
using BibliotecaAPI.Model;
using BibliotecaAPI.Persistência;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;
        public UsuarioController(BibliotecaDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _context.Usuarios.SingleOrDefault(l => l.Id == id);

            if (usuario is null)
            {
                return NotFound();
            }

            var model = UsuarioViewModel.FromEntity(usuario);

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post(CriacaoUsuarioInputModel model)
        {
            var usuario = new Usuario(model.NomeCompleto, model.Email, model.telefone);

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
