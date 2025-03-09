using AutoMapper;
using CarServiceSite.BLL.Mappers;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.InputModels;
using CarServiceSite.Core.OutputModels;
using CarServiceSite.DAL;

namespace CarServiceSite.BLL
{
    public class UserManager
    {

        private UserRepository _userRepository;
        private Mapper _mapper;

        public UserManager()
        {
            this._userRepository = new();
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserMapperProfile());
            });
            this._mapper = new Mapper(configuration);
        }

        public UserOutputModel GetUserById(int id)
        {
            UserDto userDto = this._userRepository.GetUserById(id);
            UserOutputModel outputModel = this._mapper.Map<UserOutputModel>(userDto);
            return outputModel;
        }

        public void AddCommentByUserId(CommentInputModel comment, int userId)
        {
            CommentDto commentDto = this._mapper.Map<CommentDto>(comment);
            this._userRepository.AddCommentByUserId(commentDto, userId);
        }

        public UserOutputModel GetCurrentUser()
        {
            return _mapper.Map<UserOutputModel>(SingleContext.GetInstance().Context.Users.Where(u => u.Id == 1).FirstOrDefault());
        }
    }
}
