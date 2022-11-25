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
using static Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.FuncoesDieta;
using static Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.GlobalFunctions;


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

        // GET: DietasSelector
        //public IActionResult DietasSelector()
        //{


        //    return View("Views/Dieta/DietaSelector.cshtml");

        //}



        // DIETA CREATOR
        public async Task<IActionResult> DietaSelector([Bind("DataDieta,TituloDieta,NumeroRefeicoes,Objetivo,UsuarioId")] Dieta dieta)
        {

            string userIdValue = "";
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
                var userIdClaim = claimsIdentity.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                    userIdValue = userIdClaim.Value;
                }
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);


            var dadosPessoais = await _context.DadoPessoais
                .OrderByDescending(x => x.DataFicha)
                .FirstOrDefaultAsync(m => m.UsuarioId == usuario.Id);


            DateTime dataNasc = DataConversor(usuario.DataNasc);
            
            int idadeDoUsuario = IdadeCalculator(dataNasc);

            dieta.NumeroRefeicoes = 4;

            double taxaMetabolicaBasalDiaria = FuncaoHarrisBenedict(

                    (int)usuario.SexoBiologico,
                    idadeDoUsuario,
                    dadosPessoais.Peso,
                    dadosPessoais.Altura,
                    (int)dadosPessoais.Tipo,
                    (int)dieta.Objetivo
                    );

            List<double> taxaMetabolicaBasalPorRefeicoes = CalculaCaloriaPorRefeicoes(dieta.NumeroRefeicoes, taxaMetabolicaBasalDiaria);

            List<int> alimentosId = new List<int>();
            
            List<Alimento> alimentos = new List<Alimento>();

            List<Alimento> alimentosQuantidadeCorreta = new List<Alimento>();

            List<Alimento[]> refeicoes = new List<Alimento[]>();


            for (int i = 1; i <= dieta.NumeroRefeicoes; i++)
            {
                alimentosId = RetornaIdAlimento(

                    usuario.IsIntoleranteLactose,
                    usuario.IsAlergicoFrutosMar,
                    i
                    );

                for(int j = 1; j <= alimentosId.Count; j++)
                {

                    alimentos.Add(await _context.Alimentos
                    .FirstOrDefaultAsync(m => m.Id == alimentosId[j - 1]));

                }

                alimentosQuantidadeCorreta = AtribuiCaloriaAlimentos(taxaMetabolicaBasalPorRefeicoes[i - 1], alimentos);

                refeicoes.Add(alimentosQuantidadeCorreta.ToArray());

                alimentos.Clear();

            }

                return View("Views/Dieta/DietaSelector.cshtml", refeicoes);

        }

        // GET: Dietas/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "ConfirmacaoSenha");
            return View();
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
