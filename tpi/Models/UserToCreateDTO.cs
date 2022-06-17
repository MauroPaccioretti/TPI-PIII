using System.ComponentModel.DataAnnotations;

namespace tpi.Models
{
    public class UserToCreateDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Id { get; set; }

        public UserToCreateDTO(string name, string role, string id)
        {
            Name = name;
            Role = role;
            Id = id;
        }
    }
}
