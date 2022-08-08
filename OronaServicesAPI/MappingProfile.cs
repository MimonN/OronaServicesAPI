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
        }
    }
}
