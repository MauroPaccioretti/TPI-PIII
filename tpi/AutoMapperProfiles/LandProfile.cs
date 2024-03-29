﻿using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class LandProfile:Profile
    {
        public LandProfile()
        {
            CreateMap<Entities.Land, Models.LandDTO>();
            CreateMap<Entities.Land, Models.LandIdDTO>();
            CreateMap<Entities.Land, Models.LandAuxDTO>();
            CreateMap<Models.LandDTO, Entities.Land >();
            CreateMap<Entities.Land, Models.LandWithExpensesDTO>();
            CreateMap<Models.LandToUpdateDTO, Entities.Land>();
            CreateMap<Models.LandToUpdateOwnerDTO, Entities.Land>();
        }
    }
}
