using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public async Task<IActionResult> WaterCalc()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Usuarios");
            }

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

                return View();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);

            var dadosPessoais = await _context.DadoPessoais
                .OrderBy(x => x.Id)
                .LastOrDefaultAsync(m => m.UsuarioId == usuario.Id);

            if (dadosPessoais == null)
            {
                ViewBag.Message = "Dados pessoais não encontrados";

                return RedirectToAction("DadosForm", "DadoPessoais");
            }

            string AguaPorPeso = (dadosPessoais.Peso * 35).ToString() + "ML por dia";

            return View("Views/Home/Water.cshtml", AguaPorPeso);

        }

        public async Task<IActionResult> Index()
        {

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Usuarios");
            }

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

                return View();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);



            var dietas = _context.Dietas
                .Where(m => m.UsuarioId == usuario.Id)
                .OrderByDescending(c => c.Id)
                .Take(3);

            return View(dietas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}