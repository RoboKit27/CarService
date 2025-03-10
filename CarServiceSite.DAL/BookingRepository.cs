using CarServiceSite.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.DAL
{
    public class BookingRepository
    {

        private Context _context;

        public BookingRepository()
        {
            _context = SingleContext.GetInstance().Context;
        }

        public List<WorkDto> GetAllWorks()
        {
            var works = _context.Works.ToList();
            return works;
        }
    }
}
