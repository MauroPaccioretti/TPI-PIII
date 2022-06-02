using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Dirección de email inválida")]
        public string Email { get; set; }


        [Required]
        [MaxLength(50)]
        public string Password { get; set; }


        [ForeignKey("TipoPersonaId")]
        public TipoPersona? TipoPersona { get; set; }
        public int TipoPersonaId { get; set; }

        public Persona(string name, string email, string password)
        {
            Name = name.Trim();
            Email = email;
            Password = password;
        }
    }
}
