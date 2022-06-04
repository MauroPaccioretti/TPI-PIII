using tpi.Entities;

namespace tpi.Models
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TipoPersona TipoPersona { get; set; }

    }
}
