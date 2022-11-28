using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;


namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{
    public class FuncoesDieta
    {

        //RETORNA O ID DO ALIMENTO
        public static List<int> RetornaIdAlimento(

            bool intoleranteLactose,
            bool alergicoFrutosMar,
            int refeicaoNumero
            )
        {



            List<int> alimentosSelecionadosRefeicao = new List<int>();
            var random = new Random();



            if (refeicaoNumero == 1)
            {
                //Café da manhã

                List<int> cafesId = new List<int>();

                int[] cafesManha = {
                    25,
                    48,
                    49,
                    50,
                    51,
                    52,
                    53,
                    54,
                    56,
                    58,
                    63,
                    140,
                    389,
                    424,
                    163, 
                    164,
                    165, 
                    166, 
                    167, 
                    168, 
                    169, 
                    170, 
                    171, 
                    172, 
                    173, 
                    174, 
                    175, 
                    176, 
                    177, 
                    178, 
                    179, 
                    180, 
                    181, 
                    182, 
                    183, 
                    184, 
                    185, 
                    186, 
                    187, 
                    188, 
                    189, 
                    190, 
                    191,
                    192, 
                    193, 
                    194, 
                    195, 
                    196, 
                    197, 
                    198, 
                    199, 
                    200, 
                    201, 
                    202, 
                    203, 
                    204, 
                    205, 
                    206, 
                    207, 
                    208, 
                    209, 
                    210, 
                    211, 
                    212, 
                    213, 
                    214,
                    215, 
                    216, 
                    217, 
                    218, 
                    219, 
                    220, 
                    221, 
                    222, 
                    223, 
                    224,
                    225, 
                    226, 
                    227, 
                    228, 
                    229, 
                    230, 
                    231, 
                    232, 
                    233, 
                    234, 
                    235, 
                    236, 
                    237, 
                    238, 
                    239, 
                    240, 
                    241, 
                    242, 
                    243, 
                    244, 
                    245, 
                    246, 
                    247, 
                    248, 
                    249, 
                    250, 
                    251, 
                    252, 
                    253, 
                    254, 
                    255, 
                    256, 
                    257, 
                    258,
                    488,
                    507,
                    587,
                    440
                };
                cafesId.AddRange(cafesManha);

                if(intoleranteLactose == true)
                {

                    int index = random.Next(cafesId.Count);
                    alimentosSelecionadosRefeicao.Add(cafesId[index]);

                } 
                else
                {
                    int[] cafesManhaLactose = {
                    448,
                    449,
                    450,
                    451,
                    452,
                    453,
                    454,
                    455,
                    456,
                    457,
                    458,
                    459,
                    460,
                    461,
                    462,
                    463,
                    464,
                    465,
                    466,
                    467,
                    468,
                    469
                    };
                    cafesId.AddRange(cafesManhaLactose);

                    int index = random.Next(cafesId.Count);
                    alimentosSelecionadosRefeicao.Add(cafesId[index]);


                }

            } 
            
            
            else if(refeicaoNumero == 2 || refeicaoNumero == 3)
            {
                //Refeições principais (almoço e janta)

                int[] chanceRefeicaoProntaItens = { 1, 2, 3, 4, 5 };

                List<int> chanceRefeicaoPronta = new List<int>();
                chanceRefeicaoPronta.AddRange(chanceRefeicaoProntaItens);


                int indexRefeicaoPronta = random.Next(chanceRefeicaoPronta.Count);
             

                if (chanceRefeicaoPronta[indexRefeicaoPronta] == 4)
                {
                    //Sera usado uma refeicao pronta

                    int[] refeicoesProntas =
                    {
                        525,
                        526,
                        527,
                        528,
                        529,
                        530,
                        531,
                        532,
                        533,
                        534,
                        535,
                        536,
                        537,
                        538,
                        539,
                        540,
                        541,
                        542,
                        543,
                        544,
                        545,
                        546,
                        547,
                        548,
                        549,
                        550,
                        551,
                        552,
                        553,
                        554,
                        555,
                        556
                    };

                    List<int> refeicoesProntasId = new List<int>();

                    refeicoesProntasId.AddRange(refeicoesProntas);

                    int index = random.Next(refeicoesProntasId.Count);
                    alimentosSelecionadosRefeicao.Add(refeicoesProntasId[index]);

                }
                else
                {

                    int[] principaisAlimentos = { 
                        1,
                        1,
                        1,
                        1,
                        3,
                        3,
                        40,
                        41,
                        88,
                        129,

                    };

                    int[] secundariosAlimentos = {
                        559,
                        560,
                        561,
                        561,
                        561,
                        561,
                        563,
                        565,
                        567,
                        572,
                        573,
                        577,
                        488,
                        490,
                        182,
                        37,

                    };

                    int[] carnes = {
                        273,
                        274,
                        276,
                        277,
                        280,
                        281,
                        282,
                        283,
                        289,
                        290,
                        293,
                        294,
                        297,
                        300,
                        301,
                        303,
                        305,
                        306,
                        308,
                        309,
                        311,
                        313,
                        315,
                        317,
                        318,
                        319,
                        320,
                        324,
                        325,
                        326,
                        328,
                        331,
                        332,
                        335,
                        337,
                        338,
                        340,
                        342,
                        344,
                        346,
                        347,
                        349,
                        351,
                        353,
                        356,
                        358,
                        359,
                        361,
                        363,
                        365,
                        368,
                        370,
                        371,
                        374,
                        377,
                        378,
                        381,
                        383,
                        383,
                        388,
                        392,
                        393,
                        395,
                        396,
                        398,
                        403,
                        404,
                        406,
                        408,
                        410,
                        411,
                        413,
                        416,
                        417,
                        419,
                        420,
                        425,
                        428,
                        429,
                        430,
                        432,
                        435,
                        484
                    };

                    int[] saladas = {
                        64,
                        68,
                        68,
                        70,
                        72,
                        73,
                        74,
                        75,
                        76,
                        77,
                        78,
                        79,
                        80,
                        81,
                        82,
                        83,
                        84,
                        85,
                        86,
                        88,
                        91,
                        93,
                        94,
                        95,
                        100,
                        101,
                        107,
                        108,
                        109,
                        110,
                        111,
                        112,
                        113,
                        114,
                        115,
                        116,
                        117,
                        118,
                        119,
                        120,
                        121,
                        122,
                        123,
                        124,
                        126,
                        127,
                        128,
                        129,
                        131,
                        132,
                        136,
                        142,
                        143,
                        147,
                        148,
                        149,
                        150,
                        151,
                        152,
                        153,
                        154,
                        155,
                        156,
                        157,
                        158,
                        159,
                        160,
                        161,
                        162
                    };


                    List<int> principaisAlimentosId = new List<int>();
                    List<int> secundariosAlimentosId = new List<int>();
                    List<int> carnesId = new List<int>();
                    List<int> saladasId = new List<int>();

                    principaisAlimentosId.AddRange(principaisAlimentos);
                    secundariosAlimentosId.AddRange(secundariosAlimentos);
                    carnesId.AddRange(carnes);
                    saladasId.AddRange(saladas);

                    int[] chanceAlimentoSecundarioItems = { 1, 2, 3, 4};

                    List<int> chanceAlimentoSecundario = new List<int>();
                        chanceAlimentoSecundario.AddRange(chanceAlimentoSecundarioItems);
                    
                    int indexChanceAlimentos = random.Next(chanceAlimentoSecundario.Count);



                    int index = random.Next(principaisAlimentosId.Count);
                    alimentosSelecionadosRefeicao.Add(principaisAlimentosId[index]);


                    if(alergicoFrutosMar == true)
                    {
                        index = random.Next(carnesId.Count);
                        alimentosSelecionadosRefeicao.Add(carnesId[index]);

                    } else
                    {
                        //adicionando frutos do mar na listagem

                        int[] frutosDoMar = {
                            284,
                            286,
                            287
                        };

                        carnesId.AddRange(frutosDoMar);
                        
                        index = random.Next(carnesId.Count);
                        alimentosSelecionadosRefeicao.Add(carnesId[index]);

                    }


                    index = random.Next(saladasId.Count);
                    alimentosSelecionadosRefeicao.Add(saladasId[index]);


                    if (secundariosAlimentos[indexChanceAlimentos] != 3)
                    {
                        index = random.Next(secundariosAlimentosId.Count);
                        alimentosSelecionadosRefeicao.Add(secundariosAlimentosId[index]);
                    }


                }

            } 
            
            
            else
            {
                //Lanches ( mais de 3 refeições )

                 List<int> lanchesId = new List<int>();

                int[] lanches = {
                        25,
                        48,
                        49,
                        50,
                        51,
                        52,
                        53,
                        54,
                        56,
                        58,
                        63,
                        140,
                        389,
                        424,
                        163,
                        164,
                        165,
                        166,
                        167,
                        168,
                        169,
                        170,
                        171,
                        172,
                        173,
                        174,
                        175,
                        176,
                        177,
                        178,
                        179,
                        180,
                        181,
                        182,
                        183,
                        184,
                        185,
                        186,
                        187,
                        188,
                        189,
                        190,
                        191,
                        192,
                        193,
                        194,
                        195,
                        196,
                        197,
                        198,
                        199,
                        200,
                        201,
                        202,
                        203,
                        204,
                        205,
                        206,
                        207,
                        208,
                        209,
                        210,
                        211,
                        212,
                        213,
                        214,
                        215,
                        216,
                        217,
                        218,
                        219,
                        220,
                        221,
                        222,
                        223,
                        224,
                        225,
                        226,
                        227,
                        228,
                        229,
                        230,
                        231,
                        232,
                        233,
                        234,
                        235,
                        236,
                        237,
                        238,
                        239,
                        240,
                        241,
                        242,
                        243,
                        244,
                        245,
                        246,
                        247,
                        248,
                        249,
                        250,
                        251,
                        252,
                        253,
                        254,
                        255,
                        256,
                        257,
                        258,
                        488,
                        507,
                        587,
                        440,
                        273,
                        274,
                        276,
                        277,
                        280,
                        281,
                        282,
                        283,
                        289,
                        290,
                        293,
                        294,
                        297,
                        300,
                        301,
                        303,
                        305,
                        306,
                        308,
                        309,
                        311,
                        313,
                        315,
                        317,
                        318,
                        319,
                        320,
                        324,
                        325,
                        326,
                        328,
                        331,
                        332,
                        335,
                        337,
                        338,
                        340,
                        342,
                        344,
                        346,
                        347,
                        349,
                        351,
                        353,
                        356,
                        358,
                        359,
                        361,
                        363,
                        365,
                        368,
                        370,
                        371,
                        374,
                        377,
                        378,
                        381,
                        383,
                        383,
                        388,
                        392,
                        393,
                        395,
                        396,
                        398,
                        403,
                        404,
                        406,
                        408,
                        410,
                        411,
                        413,
                        416,
                        417,
                        419,
                        420,
                        425,
                        428,
                        429,
                        430,
                        432,
                        435,
                        484,
                        386,
                        388,
                        473,
                        478,
                        484,
                        587,
                        588,
                        589,
                        590,
                        591,
                        597,
                        88,
                        94
                 };

                lanchesId.AddRange(lanches);


                if (intoleranteLactose == true)
                {

                    int index = random.Next(lanchesId.Count);
                    alimentosSelecionadosRefeicao.Add(lanchesId[index]);

                } 
                else
                {

                    int[] lanchesLactose =
                {
                    448,
                    449,
                    450,
                    451,
                    452,
                    453,
                    454,
                    455,
                    456,
                    457,
                    458,
                    459,
                    460,
                    461,
                    462,
                    463,
                    464,
                    465,
                    466,
                    467,
                    468,
                    469
                };

                    lanchesId.AddRange(lanchesLactose);

                    int index = random.Next(lanchesId.Count);
                    alimentosSelecionadosRefeicao.Add(lanchesId[index]);


                }

            }

            return alimentosSelecionadosRefeicao;

        }

        public static List<double> CalculaCaloriaPorRefeicoes(int totalRefeicoes, double totalCaloria)
        {

            List<double> CaloriasPorRefeicao = new List<double>();

            double[] result;

            switch (totalRefeicoes)
            {
                case 2:

                    // 2 refeiçoes :

                    double[] refeicoes2 = new double[2];


                    double percentual1Ref1 = 0.65;

                    double percentual1Ref2 = 0.35;

                    refeicoes2[0] = percentual1Ref1 * totalCaloria;
                    refeicoes2[1] = percentual1Ref2 * totalCaloria;

                    result = refeicoes2;

                    break;
                
                case 3:

                    // 3 refeições :

                    double[] refeicoes3 = new double[3];

                    double percentual2Ref1 = 0.22;

                    double percentual2Ref2 = 0.55;

                    double percentual2Ref3 = 0.23;

                    refeicoes3[0] = percentual2Ref1 * totalCaloria;
                    refeicoes3[1] = percentual2Ref2 * totalCaloria;
                    refeicoes3[2] = percentual2Ref3 * totalCaloria;

                    result = refeicoes3;

                    break;

                case 4:

                    // 4 refeições :

                    double[] refeicoes4 = new double[4];

                    double percentual3Ref1 = 0.15;

                    double percentual3Ref2 = 0.42;

                    double percentual3Ref3 = 0.23;

                    double percentual3Ref4 = 0.20;


                    refeicoes4[0] = percentual3Ref1 * totalCaloria;
                    refeicoes4[1] = percentual3Ref2 * totalCaloria;
                    refeicoes4[2] = percentual3Ref3 * totalCaloria;
                    refeicoes4[3] = percentual3Ref4 * totalCaloria;

                    result = refeicoes4;

                    break;

                case 5:

                    // 5 refeicoes :

                    double[] refeicoes5 = new double[5];


                    double percentual4Ref145 = 0.15;

                    double percentual4Ref2 = 0.37;

                    double percentual4Ref3 = 0.18;


                    refeicoes5[0] = percentual4Ref145 * totalCaloria;
                    refeicoes5[1] = percentual4Ref2 * totalCaloria;
                    refeicoes5[2] = percentual4Ref3 * totalCaloria;
                    refeicoes5[3] = percentual4Ref145 * totalCaloria;
                    refeicoes5[4] = percentual4Ref145 * totalCaloria;

                    result = refeicoes5;

                    break;

                default:

                    // 6 Refeições :

                    double[] refeicoes6 = new double[6];


                    double percentual5Ref1 = 0.11;

                    double percentual5Ref2 = 0.27;

                    double percentual5Ref3 = 0.17;

                    double percentual5Ref456 = 0.15;



                    refeicoes6[0] = percentual5Ref1 * totalCaloria;
                    refeicoes6[1] = percentual5Ref2 * totalCaloria;
                    refeicoes6[2] = percentual5Ref3 * totalCaloria;
                    refeicoes6[3] = percentual5Ref456 * totalCaloria;
                    refeicoes6[4] = percentual5Ref456 * totalCaloria;
                    refeicoes6[5] = percentual5Ref456 * totalCaloria;

                    result = refeicoes6;

                    break;

            }

            CaloriasPorRefeicao.AddRange(result);


            return CaloriasPorRefeicao;
        }

        private static int QuantidadeDoAlimento(double caloriaPorRefeicao, Alimento alimento)
        {
            double energiaDiferenca;

            double porcentagemDiferenca;

            if (alimento.EnergiaKcal == "NA" || alimento.EnergiaKcal == "Tr" || alimento.EnergiaKcal == "*")
            {
                return 0;
            }

            double EnergiaKcal = double.Parse(alimento.EnergiaKcal.Replace(',', '.'));


            if (EnergiaKcal > caloriaPorRefeicao)
            {
                energiaDiferenca = (EnergiaKcal - caloriaPorRefeicao);

                porcentagemDiferenca = (energiaDiferenca * 100) / EnergiaKcal;

                return Convert.ToInt32(alimento.Qtde - porcentagemDiferenca);

            }
            else if (EnergiaKcal == caloriaPorRefeicao)
            {
                return alimento.Qtde;
            }
            else
            {
                energiaDiferenca = (caloriaPorRefeicao - EnergiaKcal);

                porcentagemDiferenca = (energiaDiferenca * 100) / EnergiaKcal;

                return Convert.ToInt32(alimento.Qtde + porcentagemDiferenca);
            }

        }


        private static double CalculoAtributosBaseQTDE(double qtde, string atributo)
        {

            if(atributo == "NA" || atributo == "Tr" || atributo == "*")
            {
                return 0;
            }

            double atributoConvertido = double.Parse(atributo.Replace(',', '.'));

            double atributoResultado;

            double diferencaQtde;

            if (qtde > 100)
            {
                diferencaQtde = (qtde - 100);

                atributoResultado = (atributoConvertido * (diferencaQtde * 0.01));

                atributoResultado += atributoConvertido;

                return atributoResultado;

            }
            else if (qtde == 100)
            {
                return atributoConvertido;
            }
            else
            {
                diferencaQtde = (100 - qtde);

                atributoResultado = (atributoConvertido * (diferencaQtde * 0.01));

                atributoConvertido -= atributoResultado;

                return atributoConvertido;
            }

        }

        public static List<Alimento> AtribuiCaloriaAlimentos(double caloriaPorRefeicao, List<Alimento> alimentosRefeicao)
        {

            List<Alimento> alimentos = alimentosRefeicao;

            double caloriaPorAlimento;

            if(alimentos.Count == 1)
            {
                caloriaPorAlimento = caloriaPorRefeicao;
            } else if(alimentos.Count == 2)
            {
                caloriaPorAlimento = caloriaPorRefeicao / 2;
            } else if(alimentos.Count == 3)
            {
                caloriaPorAlimento = caloriaPorRefeicao / 3;
            } else
            {
                caloriaPorAlimento = caloriaPorRefeicao / 4;
            };

            foreach (Alimento alimento in alimentos)
            {
                alimento.Qtde = QuantidadeDoAlimento(caloriaPorAlimento, alimento);
                alimento.Carboidrato = (CalculoAtributosBaseQTDE(alimento.Qtde, alimento.Carboidrato)).ToString("0.00");
                alimento.EnergiaKcal = (CalculoAtributosBaseQTDE(alimento.Qtde, alimento.EnergiaKcal)).ToString("0.00");
                alimento.Proteina = (CalculoAtributosBaseQTDE(alimento.Qtde, alimento.Proteina)).ToString("0.00");
                alimento.Lipideos = (CalculoAtributosBaseQTDE(alimento.Qtde, alimento.Lipideos)).ToString("0.00");
            }


            return alimentos;


        }

    }

}













