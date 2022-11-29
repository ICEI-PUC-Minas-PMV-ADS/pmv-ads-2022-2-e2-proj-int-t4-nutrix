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

            var dadosPessoais = await _context.DadoPessoais
                .FirstOrDefaultAsync(m => m.UsuarioId == usuario.Id);

            if(dadosPessoais == null)
            {
                ViewBag.Message = "Preencha os dados pessoais para gerar a dietas";

                return RedirectToAction("DadosForm", "DadoPessoais");
            }

            if(usuario.DataNasc == null)
            {
                return RedirectToAction("Edit", "Usuarios");
            }



            //criando dieta
            Dieta dietaObject = dieta;

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString();
            string minuto = DateTime.Now.Minute.ToString();

            dietaObject.DataDieta = (ano + "-" + mes + "-" + dia + "T" + hora + ":" + minuto);

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
    }
}
