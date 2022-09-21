using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace OronaServicesAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Window, WindowDto>();
            CreateMap<WindowForCreationDto, Window>();
            CreateMap<WindowForUpdateDto, Window>();
            CreateMap<ContactUsForCreationDto, ContactUs>().ReverseMap();
            CreateMap<ContactUsDto, ContactUs>().ReverseMap();
            CreateMap<ContactUsForUpdateDto, ContactUs>().ReverseMap();

            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
