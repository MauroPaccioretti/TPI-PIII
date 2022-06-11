using System.ComponentModel.DataAnnotations;

namespace tpi.Entities
{
    public class PersonType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }

        public PersonType(string type)
        {
            Type = type;
        }
    }
}
