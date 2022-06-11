using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class PersonaProfile : Profile
    {

        public PersonaProfile()
        {
            CreateMap<Entities.Person, Models.PersonDTO>();

        }
    }
}
