using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{
    public class RefeicoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RefeicoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Refeições Generator

        public async Task<IActionResult> Index()
        {

            var applicationDbContext = _context.Refeicoes.Include(r => r.Dieta);
            return View(await applicationDbContext.ToListAsync());

        }


        // GET: Refeicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Refeicoes == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes
                .Include(r => r.Dieta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicao == null)
            {
                return NotFound();
            }

            return View(refeicao);
        }

        // GET: Refeicoes/Create
        public IActionResult Create()
        {
            ViewData["DietaId"] = new SelectList(_context.Dietas, "Id", "TituloDieta");
            return View();
        }

        // POST: CRIAÇÃO DAS REFEIÇÕES

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumeroRefeicao,DietaId")] Refeicao refeicao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refeicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DietaId"] = new SelectList(_context.Dietas, "Id", "TituloDieta", refeicao.DietaId);
            return View(refeicao);
        }

        // GET: Refeicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Refeicoes == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes.FindAsync(id);
            if (refeicao == null)
            {
                return NotFound();
            }
            ViewData["DietaId"] = new SelectList(_context.Dietas, "Id", "TituloDieta", refeicao.DietaId);
            return View(refeicao);
        }

        // POST: Refeicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumeroRefeicao,DietaId")] Refeicao refeicao)
        {
            if (id != refeicao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refeicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefeicaoExists(refeicao.Id))
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
            ViewData["DietaId"] = new SelectList(_context.Dietas, "Id", "TituloDieta", refeicao.DietaId);
            return View(refeicao);
        }

        // GET: Refeicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Refeicoes == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes
                .Include(r => r.Dieta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicao == null)
            {
                return NotFound();
            }

            return View(refeicao);
        }

        // POST: Refeicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Refeicoes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Refeicoes'  is null.");
            }
            var refeicao = await _context.Refeicoes.FindAsync(id);
            if (refeicao != null)
            {
                _context.Refeicoes.Remove(refeicao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefeicaoExists(int id)
        {
          return _context.Refeicoes.Any(e => e.Id == id);
        }
    }
}
