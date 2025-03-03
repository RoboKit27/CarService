using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.DAL
{
    public class SingleContext
    {
        public Context Context { get; set; }

        private static SingleContext _instance;

        private SingleContext()
        {
            Context = new Context();
        }

        public static SingleContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingleContext();
            }

            return _instance;
        }
    }
}
