using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{

    [Table("DadosPessoais")]
    public class DadoPessoal
    {
        public int Id { get; set; }


        [DataType(DataType.DateTime)]
        public string DataFicha { get; set; }


        [Required(ErrorMessage = "Informe seu Peso")]
        [Range(10, 250)]
        public int Peso { get; set; }


        [Required(ErrorMessage = "Informe sua Altura (CM)")]
        [Range(1, 400)]
        public int Altura { get; set; }


        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]


        public FrequenciaAtvFisica Tipo { get; set; }

    }

    public enum FrequenciaAtvFisica
    {
        Sedentário,
        Leve,
        Moderado
    }
}


