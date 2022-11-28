using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient.Server;
using System.Globalization;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{
    public class GlobalFunctions
    {

        public static string IMCCalculator(int altura, int peso)
        {

            float IMC = peso / (altura * altura);

            string IMCClassificacao;


            if (IMC < 18.5)
            {

                IMCClassificacao = "Abaixo do peso";

            }
            else if (IMC < 24.9)
            {
                IMCClassificacao = "Peso Ideal";

            }
            else if (IMC < 29.9)
            {
                IMCClassificacao = "Sobrepeso";

            }
            else if (IMC < 34.9)
            {
                IMCClassificacao = "Obesidade I";

            }
            else if (IMC < 39.9)
            {
                IMCClassificacao = "Obesidade II";

            }
            else
            {
                IMCClassificacao = "Obesidade III";
            }

            return IMCClassificacao;
        }

        public static double FuncaoHarrisBenedict(int genero, int idade, int peso, int altura, int atividadeFisica, int objetivo)
        {

            double energiaDiaria;

            if(genero == 0)
            {
                //para homens

                energiaDiaria = 66 + (13.7 * peso) + (5 * altura) - (6.8 * idade);


            } else
            {

                //para mulheres

                energiaDiaria = 665 + (9.6 * peso) + (1.8 * altura) - (4.7 * idade);

            }

            switch (atividadeFisica) 
            
            { 
            
                //sedentario
                case 0:

                energiaDiaria = energiaDiaria * 1.2;

                    break;

                //Atividade leve
                case 1:

                energiaDiaria = energiaDiaria * 1.375;

                    break;

                //Atividade moderada
                default:

                energiaDiaria = energiaDiaria * 1.55;

                    break;
            }


            switch(objetivo)
            {
                //perda de peso
                case 0:

                    energiaDiaria = energiaDiaria - 500;
                    break;
                
                //manter peso
                case 1:

                    break;

                //ganhar peso
                default:

                    energiaDiaria = energiaDiaria + 500;
                    break;
            }

            return energiaDiaria;


        }

        public static int IdadeCalculator(DateTime dtNasc)
        {

            int idade = DateTime.Now.Year - dtNasc.Year;

            if (DateTime.Now.DayOfYear < dtNasc.DayOfYear)
            {

                idade = --idade;

            };

            return idade;

        }

        public static DateTime DataConversor(string dataString)
        {

            //dd.mm.aaaa

            CultureInfo provider = CultureInfo.InvariantCulture;

            string format = "dd.MM.yyyy";


            var data = DateTime.ParseExact(dataString, format, provider);

            return data;

        }
    }
}
