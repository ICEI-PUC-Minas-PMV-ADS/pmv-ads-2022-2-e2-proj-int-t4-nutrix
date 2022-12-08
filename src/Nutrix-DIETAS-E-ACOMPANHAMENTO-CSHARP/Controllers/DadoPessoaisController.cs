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
    public class DadoPessoaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DadoPessoaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DadoPessoais
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DadoPessoais.Include(d => d.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult DadosForm()
        {
            return View("Views/DadosPessoais/View.cshtml");

        }


        // POST: DadoPessoais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public async Task<IActionResult> CreateDadoPessoal([Bind("Id,Peso,Altura,Tipo,UsuarioId")] DadoPessoal dadoPessoal)
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

                return View("Views/DadosPessoais/View.cshtml");
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == userIdValue);

            

            DadoPessoal dadoPessoalToSave = dadoPessoal;

            dadoPessoalToSave.UsuarioId = usuario.Id;


            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString();
            string minuto = DateTime.Now.Minute.ToString();

            dadoPessoalToSave.DataFicha = (ano + "-" + mes + "-" + dia + "T" + hora + ":" + minuto);



            _context.Add(dadoPessoalToSave);
                await _context.SaveChangesAsync();


            return RedirectToAction("Index", "Home");

        }
    }
}
