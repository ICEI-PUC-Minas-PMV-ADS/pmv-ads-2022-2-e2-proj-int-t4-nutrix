using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

            //Refeições Generator
        }

        public async Task<IActionResult> RefeicaoSaver()
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


                //criando refeicoes

                var dietaBd = await _context.Dietas
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync(m => m.UsuarioId == usuario.Id);


            for (int i = 1; i <= dietaBd.NumeroRefeicoes; i++)
                {

                Refeicao refeicaoObject = new Refeicao();


                refeicaoObject.NumeroRefeicao = i;


                    refeicaoObject.DietaId = dietaBd.Id;


                    _context.Add(refeicaoObject);

                }

            await _context.SaveChangesAsync();


            return RedirectToAction("RefeicaoAlimentoSaver", "RefeicoesAlimento");


            }

        
    }
}
