using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_work.DB
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Route> Route { get; set; }
        public int Cost { get; set; }
        public DateTime Time_Departure { get; set; }
        public DateTime Time_Registration { get; set; }

    }
}
