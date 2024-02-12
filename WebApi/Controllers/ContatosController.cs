using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContatosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContatoModel>>> GetContatos()
        {
            return await _context.Contatos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContatoModel>> GetContatoModel(int id)
        {
            var contatoModel = await _context.Contatos.FindAsync(id);

            if (contatoModel == null)
            {
                return NotFound();
            }

            return contatoModel;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContatoModel(int id, ContatoModel contatoModel)
        {
            if (id != contatoModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(contatoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContatoModelExists(id))
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

        [HttpPost]
        public async Task<ActionResult<ContatoModel>> PostContatoModel(ContatoModel contatoModel)
        {
            _context.Contatos.Add(contatoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContatoModel", new { id = contatoModel.Id }, contatoModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContatoModel(int id)
        {
            var contatoModel = await _context.Contatos.FindAsync(id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContatoModelExists(int id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }
    }
}
