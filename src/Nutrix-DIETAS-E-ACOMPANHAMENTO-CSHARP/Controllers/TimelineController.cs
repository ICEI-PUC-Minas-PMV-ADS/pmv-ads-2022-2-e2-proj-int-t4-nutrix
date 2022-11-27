using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Migrations;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;
using System.Security.Claims;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{
    public class TimelineController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TimelineController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userEmail = User.FindFirst(ClaimTypes.Email).Value;

                var userId = _context.Usuarios.Where(u => u.Email == userEmail).First().Id;

                var dados = _context.DadoPessoais.Where(m => m.UsuarioId == userId).ToList();

                return View(dados);
            }
            else
            {
                return RedirectToAction("Login", "Usuarios");
            }
        }
    }
}
