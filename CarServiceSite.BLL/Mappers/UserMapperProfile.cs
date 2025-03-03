using AutoMapper;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.InputModels;
using CarServiceSite.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.BLL.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile() 
        {
            CreateMap<UserDto,UserOutputModel>();
            CreateMap<UserOutputModel,UserDto>();
            
            CreateMap<RoleDto,RoleOutputModel>();
            CreateMap<RoleOutputModel,RoleDto>();

            CreateMap<CommentDto,CommentOutputModel>();
            CreateMap<CommentInputModel,CommentDto>();
        }
    }
}
