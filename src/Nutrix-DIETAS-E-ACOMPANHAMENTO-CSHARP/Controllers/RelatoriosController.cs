using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Migrations;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;
using System.Security.Claims;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{
    public class RelatoriosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RelatoriosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuarios");
            }
        }

        public async Task<IActionResult> DietasCriadas()
        {
            if (User.Identity.IsAuthenticated)
            {
                IQueryable<Dieta> dietas = _context.Dietas;
                var numDietas = dietas.Count();
                ViewData["Count"] = numDietas;
                return View("Views/Relatorios/DietasCriadas.cshtml");
            }
            else
            {
                return RedirectToAction("Login", "Usuarios");
            }
        }

        public async Task<IActionResult> Peso()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userEmail = User.FindFirst(ClaimTypes.Email).Value;

                var userId = _context.Usuarios.Where(u => u.Email == userEmail).First().Id;


                var pesos = _context.DadoPessoais.Where(m => m.UsuarioId == userId).ToList();

                return View("Views/Relatorios/Peso.cshtml", pesos);
            }
            else
            {
                return RedirectToAction("Login", "Usuarios");
            }
        }

        public async Task<IActionResult> Saude()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userEmail = User.FindFirst(ClaimTypes.Email).Value;

                var userId = _context.Usuarios.Where(u => u.Email == userEmail).First().Id;

                var dados = _context.DadoPessoais.Where(m => m.UsuarioId == userId).ToList();

                return View("Views/Relatorios/Saude.cshtml", dados);
            }
            else
            {
                return RedirectToAction("Login", "Usuarios");
            }
        }
    }
}
