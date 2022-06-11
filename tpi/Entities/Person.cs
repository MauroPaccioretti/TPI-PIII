using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public class Person
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
        public PersonType? PersonType { get; set; }
        public int PersonTypeId { get; set; }

        public Person(string name, string email, string password)
        {
            Name = name.Trim();
            Email = email;
            Password = password;
        }
    }
}
