using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class PersonProfile : Profile
    {

        public PersonProfile()
        {
            CreateMap<Entities.Person, Models.PersonDTO>();
            CreateMap<Models.PersonToCreateDTO, Entities.Person>();
            CreateMap<Models.PersonToUpdateDTO, Entities.Person>();

        }
    }
}
