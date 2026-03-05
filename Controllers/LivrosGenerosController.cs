using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Biblioteca.Data;
using API.biblioteca.Models;

namespace API.biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosGenerosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LivrosGenerosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LivrosGeneros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroGenero>>> GetLivrosGeneros()
        {
            return await _context.LivrosGeneros.ToListAsync();
        }

        // GET: api/LivrosGeneros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LivroGenero>> GetLivroGenero(Guid id)
        {
            var livroGenero = await _context.LivrosGeneros.FindAsync(id);

            if (livroGenero == null)
            {
                return NotFound();
            }

            return livroGenero;
        }

        // PUT: api/LivrosGeneros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivroGenero(Guid id, LivroGenero livroGenero)
        {
            if (id != livroGenero.LivroGeneroId)
            {
                return BadRequest();
            }

            _context.Entry(livroGenero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroGeneroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LivrosGeneros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LivroGenero>> PostLivroGenero(LivroGenero livroGenero)
        {
            _context.LivrosGeneros.Add(livroGenero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLivroGenero", new { id = livroGenero.LivroGeneroId }, livroGenero);
        }

        // DELETE: api/LivrosGeneros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivroGenero(Guid id)
        {
            var livroGenero = await _context.LivrosGeneros.FindAsync(id);
            if (livroGenero == null)
            {
                return NotFound();
            }

            _context.LivrosGeneros.Remove(livroGenero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivroGeneroExists(Guid id)
        {
            return _context.LivrosGeneros.Any(e => e.LivroGeneroId == id);
        }
    }
}
