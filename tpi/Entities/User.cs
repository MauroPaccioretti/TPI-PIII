using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Role { get; set; }

        [ForeignKey("PersonId")]
        public Person? Person { get; set; }

        [ForeignKey("PersonTypeId")]
        public PersonType? PersonType { get; set; }

        public User(string name, string role, int id)
        {
            Name = name.Trim();
            Role = role;
            Id = id;
        }
    }
}
