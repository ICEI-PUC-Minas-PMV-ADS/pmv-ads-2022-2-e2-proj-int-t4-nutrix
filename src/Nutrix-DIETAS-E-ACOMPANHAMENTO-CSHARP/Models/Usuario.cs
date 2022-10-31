using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{

    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Informe seu nome")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Informe seu Email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        [Required(ErrorMessage = "Confirme a senha")]
        [DataType(DataType.Password)]
        public string ConfirmacaoSenha{ get; set; }


        [DataType(DataType.DateTime)]
        public string? DataNasc { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(1)]
        public string? SexoBiologico { get; set; }


        public bool IsDiabetico { get; set; }


        public bool IsIntoleranteLactose { get; set; }


        public bool IsAlergicoGluten { get; set; }


        public bool IsAlergicoFrutosMar { get; set; }

        public ICollection<DadoPessoal> DadosPessoais { get; set; }

    }
}
