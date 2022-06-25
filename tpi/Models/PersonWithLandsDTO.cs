using tpi.Entities;

namespace tpi.Models
{
    public class PersonWithLandsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public PersonType PersonType { get; set; }
        public List<LandAuxDTO> LandsList { get; set; }

    }
}
