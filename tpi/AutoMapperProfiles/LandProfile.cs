using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class LandProfile:Profile
    {
        public LandProfile()
        {
            CreateMap<Entities.Land, Models.LandDTO>();
            CreateMap<Entities.Land, Models.LandWithExpensesDTO>();
        }
    }
}
