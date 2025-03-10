using CarServiceSite.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.OutputModels
{
    public class WorkOutputModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public double Time { get; set; }
    }
}
