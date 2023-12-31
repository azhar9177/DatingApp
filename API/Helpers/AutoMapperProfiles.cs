using API.DTOs;
using API.Entites;
using API.Extentions;
using AutoMapper;
namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>().ForMember(dest => dest.PhotoUrl, 
                opt => opt.MapFrom(src=> src.photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateofBirth.CalculateAge()));

            CreateMap<Photo, PhotoDto>();
        }
    }
}