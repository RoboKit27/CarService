using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.InputModels
{
    public class UserInputModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone {  get; set; }
        public string? BirthDate { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}
