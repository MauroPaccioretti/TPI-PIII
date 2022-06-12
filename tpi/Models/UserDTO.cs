namespace tpi.Models
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Id { get; set; }

        public UserDTO(string name, string role, string id)
        {
            Name = name;
            Role = role;
            Id = id;
        }
    }
}
