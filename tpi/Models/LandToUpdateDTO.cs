using System.ComponentModel.DataAnnotations;
using tpi.Entities;

namespace tpi.Models
{
    public class LandToUpdateDTO
    {
        public int ActivityMainId { get; set; }
        public int ActivityStaffSizeId { get; set; }
        public int ActivityWorkLoadId { get; set; }
        public int EnvironmentalGasesId { get; set; }
        public int EnvironmentalWasteId { get; set; }
        public int EnvironmentalWaterConsumptionId { get; set; }
        public int GeographicAreaId { get; set; }
        public int GeographicBlockId { get; set; }
        public int GeographicCoveredAreaId { get; set; }
        
    }
}
