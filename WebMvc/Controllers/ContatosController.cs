using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMvc.Data;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class ContatosController : Controller
    {
        private readonly AppDbContext _context;

        public ContatosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.ContatosMvc != null ? 
                          View(await _context.ContatosMvc.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.ContatosMvc'  is null.");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContatosMvc == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.ContatosMvc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,Ativo")] ContatoModel contatoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contatoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contatoModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContatosMvc == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.ContatosMvc.FindAsync(id);
            if (contatoModel == null)
            {
                return NotFound();
            }
            return View(contatoModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Telefone,Ativo")] ContatoModel contatoModel)
        {
            if (id != contatoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contatoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoModelExists(contatoModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contatoModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContatosMvc == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.ContatosMvc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContatosMvc == null)
            {
                return Problem("Entity set 'AppDbContext.ContatosMvc'  is null.");
            }
            var contatoModel = await _context.ContatosMvc.FindAsync(id);
            if (contatoModel != null)
            {
                _context.ContatosMvc.Remove(contatoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContatoModelExists(int id)
        {
          return (_context.ContatosMvc?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
