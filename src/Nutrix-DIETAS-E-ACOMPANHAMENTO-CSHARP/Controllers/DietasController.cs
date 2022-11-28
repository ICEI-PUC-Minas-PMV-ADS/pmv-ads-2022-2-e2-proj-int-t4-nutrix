using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;



namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{

    public class DietasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DietasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dietas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dietas.Include(d => d.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: DietasForm
        public IActionResult DietasForm()
        {
            return View("Views/Dieta/DietaForm.cshtml");

        }

        // GET: DietasInformation
        public IActionResult DietasInformation()
        {
            return View("Views/Dieta/DietaInformation.cshtml");

        }



        // DIETA CREATOR


        public async Task<IActionResult> DietaSelector([Bind("DataDieta,TituloDieta,NumeroRefeicoes,Objetivo,UsuarioId")] Dieta dieta)
        {

            string userIdValue = "";
            var claimsIdentity = User.Identity as ClaimsIdentity;

            try
            {
                if (claimsIdentity != null)
                {
                    var userIdClaim = claimsIdentity.Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                    if (userIdClaim != null)
                    {
                        userIdValue = userIdClaim.Value;
                    }
                }



            } catch(Exception)
            {
                ViewBag.Message = "Usuário não pôde ser selecionado, tente efetuar o login novamente.";

                return View("Views/Dieta/DietaSelector.cshtml");
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);



            //criando dieta
            Dieta dietaObject = dieta;

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            dietaObject.DataDieta = (dia + "." + mes + "." + ano);

            dietaObject.TituloDieta = dieta.TituloDieta;

            dietaObject.NumeroRefeicoes = dieta.NumeroRefeicoes;


            dietaObject.UsuarioId = usuario.Id;

            _context.Add(dietaObject);
            await _context.SaveChangesAsync();




            return RedirectToAction("RefeicaoSaver", "Refeicoes" );


        }




        
        public async Task<IActionResult> DietaReload()
        {

            string userIdValue = "";
            var claimsIdentity = User.Identity as ClaimsIdentity;

            try
            {
                if (claimsIdentity != null)
                {
                    var userIdClaim = claimsIdentity.Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                    if (userIdClaim != null)
                    {
                        userIdValue = userIdClaim.Value;
                    }
                }



            }
            catch (Exception)
            {
                ViewBag.Message = "Usuário não pôde ser selecionado, tente efetuar o login novamente.";

                return View("Views/Dieta/DietaSelector.cshtml");
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);


            var dietaBd = await _context.Dietas
            .OrderByDescending(x => x.DataDieta)
            .FirstOrDefaultAsync(m => m.UsuarioId == usuario.Id);

            var dieta = await _context.Dietas.FindAsync(dietaBd.Id);
            if (dieta != null)
            {
                _context.Dietas.Remove(dieta);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("DietaSelector", "Dietas");
        }


        // POST: Dietas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataDieta,TituloDieta,NumeroRefeicoes,Objetivo,UsuarioId")] Dieta dieta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dieta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "ConfirmacaoSenha", dieta.UsuarioId);
            return View(dieta);
        }

        // GET: Dietas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dietas == null)
            {
                return NotFound();
            }

            var dieta = await _context.Dietas.FindAsync(id);
            if (dieta == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "ConfirmacaoSenha", dieta.UsuarioId);
            return View(dieta);
        }

        // POST: Dietas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataDieta,TituloDieta,NumeroRefeicoes,Objetivo,UsuarioId")] Dieta dieta)
        {
            if (id != dieta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dieta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DietaExists(dieta.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "ConfirmacaoSenha", dieta.UsuarioId);
            return View(dieta);
        }

        // GET: Dietas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dietas == null)
            {
                return NotFound();
            }

            var dieta = await _context.Dietas
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dieta == null)
            {
                return NotFound();
            }

            return View(dieta);
        }

        // POST: Dietas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dietas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Dietas'  is null.");
            }
            var dieta = await _context.Dietas.FindAsync(id);
            if (dieta != null)
            {
                _context.Dietas.Remove(dieta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DietaExists(int id)
        {
          return _context.Dietas.Any(e => e.Id == id);
        }
    }
}
