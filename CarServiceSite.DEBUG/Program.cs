using CarServiceSite.DAL;
using CarServiceSite.Core.Dtos;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Runtime.InteropServices;

namespace CarServiceSite.DEBUG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateDatabase();
            //AddRoles();
            //AddWorks();
            //AddUsers();
        }

        static void CreateDatabase()
        {
            using (var context = SingleContext.GetInstance().Context)
            {
                context.Database.EnsureCreated();
            }
        }

        static void AddRoles()
        {
            using (var context = SingleContext.GetInstance().Context)
            {
                context.Roles.Add(new RoleDto() { Name = "Автомаляр" });
                context.Roles.Add(new RoleDto() { Name = "Автомеханик" });
                context.Roles.Add(new RoleDto() { Name = "Автоэлектрик" });
                context.Roles.Add(new RoleDto() { Name = "Шиномонтажник" });
                context.Roles.Add(new RoleDto() { Name = "Администратор" });
                context.Roles.Add(new RoleDto() { Name = "Пользователь" });
                context.SaveChanges();
            }
        }

        static void AddWorks()
        {
            using (var context = SingleContext.GetInstance().Context)
            {
                context.Works.Add(new WorkDto() 
                {
                    Name="Замена масла",
                    Cost=1300,
                    Time=0.5
                });
                context.Works.Add(new WorkDto() 
                {
                    Name="Замена свечей",
                    Cost=1100,
                    Time=0.3
                });
                context.Works.Add(new WorkDto() 
                {
                    Name="Замена тормозных колодок",
                    Cost=12600,
                    Time=1.7
                });
                context.Works.Add(new WorkDto() 
                {
                    Name="Регулировка фар",
                    Cost=5600,
                    Time=2
                });
                context.Works.Add(new WorkDto() 
                {
                    Name="Плановое ТО",
                    Cost=7299,
                    Time=1.5
                });
                context.Works.Add(new WorkDto() 
                {
                    Name="Ремонт подвески",
                    Cost=18340,
                    Time=5.1
                });
                context.SaveChanges();
            }
        }

        static void AddUsers()
        {
            using (var context = SingleContext.GetInstance().Context)
            {
                context.Users.Add(new UserDto()
                {
                    FirstName = "Артемий",
                    LastName = "Дмитров",
                    Phone = "88005553555",
                    Password = "superpass",
                    Role = context.Roles.Where(r => r.Id == 2).First(),
                    Works = new List<WorkDto>()
                    {
                        context.Works.Where(w => w.Id == 6).First(),
                        context.Works.Where(w => w.Id == 5).First(),
                        context.Works.Where(w => w.Id == 3).First()
                    }
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Василий",
                    LastName = "Вертель",
                    Phone = "83012253719",
                    Password = "vasyacrut",
                    Role = context.Roles.Where(r => r.Id == 3).First(),
                    Works = new List<WorkDto>()
                    {
                        context.Works.Where(w => w.Id == 5).First(),
                        context.Works.Where(w => w.Id == 4).First(),
                        context.Works.Where(w => w.Id == 1).First(),
                        context.Works.Where(w => w.Id == 2).First()
                    }
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Роман",
                    LastName = "Точечкин",
                    Phone = "89214787168",
                    Password = "donthackpass",
                    Role = context.Roles.Where(r => r.Id == 4).First(),
                    Works = new List<WorkDto>()
                    {
                        context.Works.Where(w => w.Id == 5).First(),
                        context.Works.Where(w => w.Id == 6).First(),
                        context.Works.Where(w => w.Id == 1).First(),
                        context.Works.Where(w => w.Id == 2).First()
                    }
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Владимир",
                    LastName = "Всемогущий",
                    Phone = "76694992593",
                    Password = "dictator",
                    Role = context.Roles.Where(r => r.Id == 5).First()
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Генадий",
                    LastName = "Скрипач",
                    Phone = "86889848653",
                    Password = "umni2003",
                    Role = context.Roles.Where(r => r.Id == 6).First()
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Иван",
                    LastName = "Малинов",
                    Phone = "74319098332",
                    Password = "prig_prig",
                    Role = context.Roles.Where(r => r.Id == 6).First()
                });
                context.Users.Add(new UserDto()
                {
                    FirstName = "Никита",
                    LastName = "Перепёлкин",
                    Phone = "81737853286",
                    Password = "roobertmls",
                    Role = context.Roles.Where(r => r.Id == 6).First()
                });
                context.SaveChanges();
            }
        }
    }
}
