using System.ComponentModel.DataAnnotations;

namespace CampeosLol.Models
{
    public class Campeao
    {
        [Key]
        [Required] 
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do campeão é obrigatório")]
        [MaxLength(50, ErrorMessage = " O tamanho máximo do nome é de 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Classe do campeão é obirgatória")]
        [MaxLength(15, ErrorMessage = "O tamanho máximo da classe é de 15 caracteres")]
        public string Classe { get; set; }
    }
}
