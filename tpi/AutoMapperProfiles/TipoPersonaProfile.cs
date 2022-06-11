using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class TipoPersonaProfile : Profile
    {
        public TipoPersonaProfile()
        {
            CreateMap<Models.PersonTypeDTO, Entities.PersonType>();
            CreateMap<Entities.PersonType, Models.PersonTypeDTO>();
        }
    }
}
