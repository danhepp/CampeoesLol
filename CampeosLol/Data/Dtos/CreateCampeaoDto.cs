using System.ComponentModel.DataAnnotations;

namespace CampeoesLol.Data.Dtos
{
    public class CreateCampeaoDto
    {
       
        [Required(ErrorMessage = "O Nome do campeão é obrigatório")]
        [StringLength(50, ErrorMessage = " O tamanho máximo do nome é de 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Classe do campeão é obirgatória")]
        [MaxLength(15, ErrorMessage = "O tamanho máximo da classe é de 15 caracteres")]
        public string Classe { get; set; }
    }
}
