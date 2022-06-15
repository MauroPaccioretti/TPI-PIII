using System.ComponentModel.DataAnnotations;
using tpi.Entities;

namespace tpi.Models
{
    public class LandToUpdateDTO
    {
        public ActivityMain? ActivityMain { get; set; }
        public ActivityStaffSize? ActivityStaffSize { get; set; }
        public ActivityWorkLoad? ActivityWorkLoad { get; set; }
        public EnvironmentalGases? EnvironmentalGases { get; set; }
        public EnvironmentalWaste? EnvironmentalWaste { get; set; }
        public EnvironmentalWaterConsumption? EnvironmentalWaterConsumption { get; set; }
        public GeographicArea? GeographicArea { get; set; }
        public GeographicBlock? GeographicBlock { get; set; }
        public GeographicCoveredArea? GeographicCoveredArea { get; set; }
        public decimal? CostActivity
        {
            get { return ActivityMain?.Price + ActivityStaffSize?.Price + ActivityWorkLoad?.Price; }
        }
        public decimal? CostEnvironmental
        {
            get { return EnvironmentalGases?.Price + EnvironmentalWaste?.Price + EnvironmentalWaterConsumption?.Price; }
        }
        public decimal? CostGeographic
        {
            get { return GeographicArea?.Price + GeographicBlock?.Price + GeographicCoveredArea?.Price; }
        }
        public decimal? CostTotal
        {
            get { return CostActivity + CostEnvironmental + CostGeographic; }
        }
    }
}
