using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.InputModels
{
    public class UserInputModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public RoleOutputModel Role { get; set; }
    }
}
