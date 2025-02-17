using CarServiceSite.Core.Dtos;

namespace CarServiceSite.DAL
{
    public class UserRepository
    {
        private List<UserDto> _users;

        public UserRepository()
        {
            this.SetUsers();
        }

        private void SetUsers()
        {
            this._users = new List<UserDto>()
            {
                new UserDto()
                {
                    Id=1,
                    FirstName="Иван",
                    LastName="Крокодилов",
                    Password="ya_lublu_pelmeni",
                    Role=new RoleDto()
                    {
                        Id=1,
                        Name="Автослесарь"
                    },
                    Comments=new List<CommentDto>()
                    {
                        new CommentDto()
                        {
                            Id=1,
                            Text="Сомнительно, но окей",
                            Rating=4,
                            Author=new UserDto()
                            {
                                Id=4,
                                FirstName="Алексей",
                                LastName="Большой",
                                Password="123456",
                                Role=new RoleDto()
                                {
                                    Id=4,
                                    Name="Пользователь"
                                }
                            }
                        }
                    }
                },
                new UserDto()
                {
                    Id=2,
                    FirstName="Максим",
                    Password="qwerty",
                    Role=new RoleDto()
                    {
                        Id=2,
                        Name="Автомаляр"
                    },
                    Comments=new List<CommentDto>()
                    {
                        new CommentDto()
                        {
                            Id=2,
                            Rating=5,
                            Author=new UserDto()
                            {
                                Id=4,
                                FirstName="Алексей",
                                LastName="Большой",
                                Password="123456",
                                Role=new RoleDto()
                                {
                                    Id=4,
                                    Name="Пользователь"
                                }
                            }
                        }
                    }
                },
                new UserDto()
                {
                    Id=3,
                    FirstName="Юрий",
                    Password="qwe!23",
                    Role=new RoleDto()
                    {
                        Id=3,
                        Name="Администратор"
                    },
                    Comments=new List<CommentDto>()
                    {
                        new CommentDto()
                        {
                            Id=3,
                            Text="УЖАСНО",
                            Rating=1,
                            Author=new UserDto()
                            {
                                Id=4,
                                FirstName="Алексей",
                                LastName="Большой",
                                Password="123456",
                                Role=new RoleDto()
                                {
                                    Id=4,
                                    Name="Пользователь"
                                }
                            }
                        },
                        new CommentDto()
                        {
                            Id=4,
                            Text="Нагрубил",
                            Rating=2,
                            Author=new UserDto()
                            {
                                Id=5,
                                FirstName="Артём",
                                Password="qqqwww",
                                Role=new RoleDto()
                                {
                                    Id=4,
                                    Name="Пользователь"
                                }
                            }
                        }
                    }
                },
                new UserDto()
                {
                    Id=4,
                    FirstName="Алексей",
                    LastName="Большой",
                    Password="123456",
                    Role=new RoleDto()
                    {
                        Id=4,
                        Name="Пользователь"
                    }
                },
                new UserDto()
                {
                    Id=5,
                    FirstName="Артём",
                    Password="qqqwww",
                    Role=new RoleDto()
                    {
                        Id=4,
                        Name="Пользователь"
                    }
                }
            };
        }

        public UserDto? GetUserById(int id)
        {
            foreach (UserDto user in this._users)
            {
                if (user.Id == id) return user;
            }
            return null;
        }

        public void AddCommentByUserId(CommentDto comment, int userId)
        {
            foreach (UserDto user in this._users)
            {
                if (user.Id == userId)
                {
                    this._users[this._users.IndexOf(user)].Comments.Add(comment);
                }
            }
        }
    }
}
