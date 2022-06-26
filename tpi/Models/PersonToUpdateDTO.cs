using System.ComponentModel.DataAnnotations;

namespace tpi.Models
{
    public class PersonToUpdateDTO
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Debe ser menor a 50 caracteres")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email no válido")]
        public string Email { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Debe ser menor a 50 caracteres")]
        public string Password { get; set; }
        [Required]
        public int PersonTypeId { get; set; }
    }
}
