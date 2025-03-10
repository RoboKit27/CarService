using AutoMapper;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.InputModels;
using CarServiceSite.Core.OutputModels;

namespace CarServiceSite.BLL.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<UserDto, UserOutputModel>();
            CreateMap<UserOutputModel, UserDto>();
            
            CreateMap<UserDto, UserInputModel>();
            CreateMap<UserInputModel, UserDto>();

            CreateMap<RoleDto, RoleOutputModel>();
            CreateMap<RoleOutputModel, RoleDto>();
        }
    }
}
