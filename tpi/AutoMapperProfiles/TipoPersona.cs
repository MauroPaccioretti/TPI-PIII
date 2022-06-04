using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class TipoPersona : Profile
    {
        public TipoPersona()
        {
            CreateMap<Models.TipoPersonaDTO, Entities.TipoPersona>();
        }
    }
}
