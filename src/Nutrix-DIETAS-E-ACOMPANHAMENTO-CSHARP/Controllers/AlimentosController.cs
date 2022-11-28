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
    public class AlimentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlimentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alimentos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Alimentos.ToListAsync());
        }

        // GET: Alimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Alimentos == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alimento == null)
            {
                return NotFound();
            }

            return View(alimento);
        }

        // GET: Alimentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Categoria,Descricao,Umidade,EnergiaKcal,EnergiaKj,Proteina,Lipideos,Colesterol,Carboidrato,FibraAlimentar,Cinzas,Calcio,Magnesio,Manganes,Fosforo,Ferro,Sodio,Potassio,Cobre,Zinco,Retinol,Re,Rae,Tiamina,Riboflavina,Piridoxina,Niacina,VitaminaC")] Alimento alimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alimento);
        }

        // GET: Alimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Alimentos == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos.FindAsync(id);
            if (alimento == null)
            {
                return NotFound();
            }
            return View(alimento);
        }

        // POST: Alimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Categoria,Descricao,Umidade,EnergiaKcal,EnergiaKj,Proteina,Lipideos,Colesterol,Carboidrato,FibraAlimentar,Cinzas,Calcio,Magnesio,Manganes,Fosforo,Ferro,Sodio,Potassio,Cobre,Zinco,Retinol,Re,Rae,Tiamina,Riboflavina,Piridoxina,Niacina,VitaminaC")] Alimento alimento)
        {
            if (id != alimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentoExists(alimento.Id))
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
            return View(alimento);
        }

        // GET: Alimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Alimentos == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alimento == null)
            {
                return NotFound();
            }

            return View(alimento);
        }

        // POST: Alimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Alimentos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Alimentos'  is null.");
            }
            var alimento = await _context.Alimentos.FindAsync(id);
            if (alimento != null)
            {
                _context.Alimentos.Remove(alimento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentoExists(int id)
        {
          return _context.Alimentos.Any(e => e.Id == id);
        }
    }
}
