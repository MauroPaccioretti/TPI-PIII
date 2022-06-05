using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class TipoPersonaProfile : Profile
    {
        public TipoPersonaProfile()
        {
            CreateMap<Models.TipoPersonaDTO, Entities.TipoPersona>();
            CreateMap<Entities.TipoPersona, Models.TipoPersonaDTO>();
        }
    }
}
