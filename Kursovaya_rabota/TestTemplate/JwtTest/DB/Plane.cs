using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_work.DB
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Airport> Airport { get; set; }
        public string Model { get; set; }
    }
}
