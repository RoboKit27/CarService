using CarServiceSite.DAL;
using CarServiceSite.Core.Dtos;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace CarServiceSite.DEBUG
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var context = new Context();
            //context.Database.EnsureCreated();

            //context.Roles.Add(new RoleDto() { Name = "Автомаляр" });
            //context.Roles.Add(new RoleDto() { Name = "Автомеханик" });
            //context.Roles.Add(new RoleDto() { Name = "Автоэлектрик" });
            //context.Roles.Add(new RoleDto() { Name = "Шиномонтажник" });
            //context.Roles.Add(new RoleDto() { Name = "Администратор" });
            //context.Roles.Add(new RoleDto() { Name = "Пользователь" });

            context.Users.Add(new UserDto()
            {
                FirstName = "Алексей",
                Phone = "88005553555",
                Password = "qwerty",
                Role = context.Roles.Where(r => r.Id == 6).First()
            });

            context.SaveChanges();

            //var userRepository = new UserRepository();
            //var login = userRepository.GetUserByPhoneAndPassword("88005553555", "qwerty");
            //if (login == null)
            //{
            //    Console.WriteLine("User not found");
            //}
            //else
            //{
            //    Console.WriteLine($"This is user has role '{login.Role.Name}' and name '{login.FirstName}'");
            //}
        }
    }
}
