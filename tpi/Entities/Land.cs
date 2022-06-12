using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public class Land
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ActivityMainId")]
        public ActivityMain? ActivityMain { get; set; }
        public int ActivityMainId { get; set; }

        [ForeignKey("ActivityStaffSizeId")]
        public ActivityStaffSize? ActivityStaffSize { get; set; }
        public int ActivityStaffSizeId { get; set; }

        [ForeignKey("ActivityWorkLoadId")]
        public ActivityWorkLoad? ActivityWorkLoad { get; set; }
        public int ActivityWorkLoadId { get; set; }

        [ForeignKey("EnvironmentalGasesId")]
        public EnvironmentalGases? EnvironmentalGases { get; set; }
        public int EnvironmentalGasesId { get; set; }

        [ForeignKey("EnvironmentalWasteId")]
        public EnvironmentalWaste? EnvironmentalWaste { get; set; }
        public int EnvironmentalWasteId { get; set; }

        [ForeignKey("EnvironmentalWaterConsumptionId")]
        public EnvironmentalWaterConsumption? EnvironmentalWaterConsumption { get; set; }
        public int EnvironmentalWaterConsumptionId { get; set; }

        [ForeignKey("GeographicAreaId")]
        public GeographicArea? GeographicArea { get; set; }
        public int GeographicAreaId { get; set; }

        [ForeignKey("GeographicBlockId")]
        public GeographicBlock? GeographicBlock { get; set; }
        public int GeographicBlockId { get; set; }

        [ForeignKey("GeographicCoveredAreaId")]
        public GeographicCoveredArea? GeographicCoveredArea { get; set; }
        public int GeographicCoveredAreaId { get; set; }

        [ForeignKey("PersonId")]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
       

    }
}
