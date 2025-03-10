using AutoMapper;
using CarServiceSite.BLL.Mappers;
using CarServiceSite.Core.OutputModels;
using CarServiceSite.Core.Dtos;
using CarServiceSite.DAL;
using CarServiceSite.Core.InputModels;
using System.Security.Claims;

namespace CarServiceSite.BLL
{
    public class UserManager
    {
        private UserRepository _userRepository;
        private Mapper _mapper;

        public UserManager() 
        {
            _userRepository = new UserRepository();

            var configuration = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile(new UserMapperProfile());
            });
            _mapper = new Mapper(configuration);
        }

        public UserOutputModel? GetUserByPhone(UserInputModel user)
        {
            UserDto? dto = _userRepository.GetUserByPhone(user.Phone);
            UserOutputModel? outputModel = _mapper.Map<UserOutputModel>(dto);
            return outputModel;
        }

        public UserOutputModel? GetUserById(int id)
        {
            var dto = _userRepository.GetUserById(id);
            var outputModel = _mapper.Map<UserOutputModel>(dto);
            return outputModel;
        }

        public int AddUser(UserInputModel user)
        {
            var dto = _mapper.Map<UserDto>(user);
            int id = _userRepository.AddUser(dto);
            return id;
        }

        public RoleOutputModel GetRoleById(int id)
        {
            var dto = _userRepository.GetRoleById(id);
            var outputModel = _mapper.Map<RoleOutputModel>(dto);
            return outputModel;
        }
    }
}
