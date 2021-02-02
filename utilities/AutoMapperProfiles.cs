using AutoMapper;
using MonsterAPI.Entities;
using MonsterAPI.Entities.DTO;

namespace MonsterAPI.utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UsersListDTO>().ReverseMap();
        }
    }
}