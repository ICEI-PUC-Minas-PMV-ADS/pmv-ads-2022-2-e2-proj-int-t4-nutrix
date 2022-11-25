using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{

    [Table("Dietas")]
    public class Dieta
    {

        [Key]
        public int Id { get; set; }


        [DataType(DataType.DateTime)]
        public string DataDieta { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(ErrorMessage = "Informe o título da dieta")]
        public string TituloDieta { get; set; }


        [Required(ErrorMessage = "Informe o número de refeições")]
        [Range(2, 6)]
        public int NumeroRefeicoes { get; set; }


        [Required(ErrorMessage = "Informe seu objetivo")]
        public ObjetivoDieta Objetivo { get; set; }


        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }


        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }


        public ICollection<Refeicao>? Refeicoes { get; set; }
    }

    public enum ObjetivoDieta
    {
        PerdaDePeso,
        ManterPeso,
        GanharPeso
    }
}
