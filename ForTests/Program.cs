using CarServiceSite.Core.Dtos;
using CarServiceSite.DAL;

namespace ForTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            //context.Database.EnsureCreated();

            //context.Roles.Add(new RoleDto() { Name="Автомаляр" });
            //context.Roles.Add(new RoleDto() { Name="Автомеханик" });
            //context.Roles.Add(new RoleDto() { Name="Автоэлектрик" });
            //context.Roles.Add(new RoleDto() { Name="Шиномонтажник" });
            //context.Roles.Add(new RoleDto() { Name="Администратор" });
            //context.Roles.Add(new RoleDto() { Name="Пользователь" });

            //context.Users.Add(new UserDto()
            //{
            //    FirstName="Иван",
            //    Password="123456",
            //    Role=new RoleDto() { Id=6, Name="Пользователь" },
            //    Comments=new List<CommentDto>()
            //    {
            //        new CommentDto()
            //        {

            //        }
            //    }
            //});

            context.Comments.Add(new CommentDto() { });

            context.SaveChanges();

            //context.Users.Add(new UserDto()
            //{
            //    FirstName = "",
            //    LastName = "",
            //    Password = "",
            //    Role = roleDto,
            //    Comments = new List<CommentDto>()
            //    {
            //    }
            //});
        }
    }
}
