using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;
using static Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.FuncoesDieta;
using static Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.GlobalFunctions;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Controllers
{

    public class RefeicoesAlimentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RefeicoesAlimentoController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> RefeicaoAlimentoSaver()
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
                .OrderBy(x => x.Id)
                .LastOrDefaultAsync(m => m.UsuarioId == usuario.Id);





            var dadosPessoais = await _context.DadoPessoais
                .OrderBy(x => x.Id)
                .LastOrDefaultAsync(m => m.UsuarioId == usuario.Id);

            if (dadosPessoais == null)
            {
                ViewBag.Message = "Dados pessoais não encontrados";

                return View("Views/Dieta/DietaSelector.cshtml");
            }




            DateTime dataNasc = DataConversor(usuario.DataNasc);

            int idadeDoUsuario = IdadeCalculator(dataNasc);



            double taxaMetabolicaBasalDiaria = FuncaoHarrisBenedict(

                    (int)usuario.SexoBiologico,
                    idadeDoUsuario,
                    dadosPessoais.Peso,
                    dadosPessoais.Altura,
                    (int)dadosPessoais.Tipo,
                    (int)dietaBd.Objetivo
                    );

            List<double> taxaMetabolicaBasalPorRefeicoes = CalculaCaloriaPorRefeicoes(dietaBd.NumeroRefeicoes, taxaMetabolicaBasalDiaria);

            List<int> alimentosId = new List<int>();

            List<Alimento> alimentos = new List<Alimento>();

            List<Alimento> alimentosQuantidadeCorreta = new List<Alimento>();

            List<Alimento[]> refeicoes = new List<Alimento[]>();


            Refeicao refeicaoBd = new Refeicao();


            for (int i = 1; i <= dietaBd.NumeroRefeicoes; i++)
            {
                alimentosId = RetornaIdAlimento(

                    usuario.IsIntoleranteLactose,
                    usuario.IsAlergicoFrutosMar,
                    i
                    );

                    refeicaoBd = await _context.Refeicoes
                        .Where(w => w.NumeroRefeicao == i)
                        .FirstOrDefaultAsync(w => w.DietaId == dietaBd.Id);


                for (int j = 1; j <= alimentosId.Count; j++)
                {
                    RefeicaoAlimento refeicaoAlimento = new RefeicaoAlimento();


                    alimentos.Add(await _context.Alimentos
                    .FirstOrDefaultAsync(m => m.Id == alimentosId[j - 1]));

                    refeicaoAlimento.RefeicaoId = refeicaoBd.Id;
                    refeicaoAlimento.AlimentoId = alimentosId[j - 1];


                   _context.RefeicoesAlimentos.Add(refeicaoAlimento);

                }


                alimentosQuantidadeCorreta = AtribuiCaloriaAlimentos(taxaMetabolicaBasalPorRefeicoes[i - 1], alimentos);

                refeicoes.Add(alimentosQuantidadeCorreta.ToArray());

                alimentos.Clear();

            }


            await _context.SaveChangesAsync();

            return View("Views/Dieta/DietaSelector.cshtml", refeicoes);


        }

        




    }
}
