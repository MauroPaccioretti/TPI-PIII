namespace tpi.Models
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public UserDTO(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
