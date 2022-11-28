using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{

    [Table("RefeicoesAlimentos")]
    public class RefeicaoAlimento
    {

        [Key]
        public int Id { get; set; }


        [Display(Name = "Refeicao")]
        public int RefeicaoId { get; set; }


        [ForeignKey("RefeicaoId")]
        public Refeicao? Refeicao{ get; set; }


        [Display(Name = "Alimento")]
        public int AlimentoId { get; set; }


        [ForeignKey("AlimentoId")]
        public Alimento? Alimento { get; set; }

    }
}
