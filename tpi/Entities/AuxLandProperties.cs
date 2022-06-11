using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public abstract class  AuxLandProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }


        [Required]
        [Range(0,double.MaxValue,ErrorMessage = "Ingrese un monto valido")]
        public decimal Price { get; set; }
        
    }
}
