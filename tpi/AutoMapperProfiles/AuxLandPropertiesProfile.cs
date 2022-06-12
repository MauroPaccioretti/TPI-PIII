using AutoMapper;
namespace tpi.AutoMapperProfiles
{
    public class AuxLandPropertiesProfile:Profile
    {
        public AuxLandPropertiesProfile()
        {
            CreateMap<Entities.AuxLandProperties, Models.AuxLandPropertiesDTO>().IncludeAllDerived();
        }
    }
}
