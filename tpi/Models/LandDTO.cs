using tpi.Entities;

namespace tpi.Models
{
    public class LandDTO
    {
        public int Id { get; set; }

        public ActivityMain? ActivityMain { get; set; }
        public ActivityStaffSize? ActivityStaffSize { get; set; }
        public ActivityWorkLoad? ActivityWorkLoad { get; set; }
        public EnvironmentalGases? EnvironmentalGases { get; set; }
        public EnvironmentalWaste? EnvironmentalWaste { get; set; }
        public EnvironmentalWaterConsumption? EnvironmentalWaterConsumption { get; set; }
        public GeographicArea? GeographicArea { get; set; }
        public GeographicBlock? GeographicBlock { get; set; }
        public GeographicCoveredArea? GeographicCoveredArea { get; set; }
    }
}
