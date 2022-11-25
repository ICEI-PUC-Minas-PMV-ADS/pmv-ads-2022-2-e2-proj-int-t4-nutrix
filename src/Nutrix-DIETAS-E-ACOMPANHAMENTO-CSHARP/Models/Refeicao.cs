using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{

    [Table("Refeicoes")]
    public class Refeicao
    {

        [Key]
        public int Id { get; set; }

        public int NumeroRefeicao { get; set; }


        [Display(Name = "Dieta")]
        public int DietaId { get; set; }


        [ForeignKey("DietaId")]
        public Dieta? Dieta { get; set; }


        public ICollection<RefeicaoAlimento>? RefeicoesAlimentos { get; set; }

    }

}
