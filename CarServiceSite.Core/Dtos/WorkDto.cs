using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.Dtos
{
    public class WorkDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public double Time { get; set; }
        public List<UserDto>? Users { get; set; }
    }
}
