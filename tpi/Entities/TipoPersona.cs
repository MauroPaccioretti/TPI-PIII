using System.ComponentModel.DataAnnotations;

namespace tpi.Entities
{
    public class TipoPersona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }

        public TipoPersona(string tipo)
        {
            Tipo = tipo;
        }
    }
}
