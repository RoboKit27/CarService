using CarServiceSite.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.OutputModels
{
    public class UserOutputModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public RoleDto Role { get; set; }
    }
}
