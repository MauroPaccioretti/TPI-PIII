using System.ComponentModel.DataAnnotations.Schema;
using tpi.Entities;

namespace tpi.Models
{
    public class LandAuxDTO
    {
        public int Id { get; set; }

        [ForeignKey("PersonId")]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
    }
}
