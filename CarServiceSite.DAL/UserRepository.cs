using CarServiceSite.Core.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.DAL
{
    public class UserRepository
    {
        private Context _context;

        public UserRepository()
        {
            _context = SingleContext.GetInstance().Context;
        }

        public UserDto? GetUserByPhone(string phone)
        {
            var user = _context.Users.Include(u => u.Role).Where(u => u.Phone==phone).FirstOrDefault();
            return user;
        }

        public UserDto? GetUserById(int id)
        {
            var user = _context.Users.Include(u => u.Role).Where(u =>u.Id==id).FirstOrDefault();
            return user;
        }

        public int? AddUser(UserDto user, int roleId)
        {
            user.Role = _context.Roles.Where(r => r.Id == roleId).FirstOrDefault();
            _context.Users.Add(user);
            _context.SaveChanges();
            int? id = _context.Users.ToList()[_context.Users.Count()-1].Id;
            return id;
        }

        public RoleDto? GetRoleById(int id)
        {
            var role = _context.Roles.Include(r => r.Users).Where(r => r.Id==id).FirstOrDefault();
            return role;
        }
    }
}
