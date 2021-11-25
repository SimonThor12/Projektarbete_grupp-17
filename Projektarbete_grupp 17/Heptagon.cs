using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Heptagon: Polygon
    {
        
        public double area { get; private set; }
        public int sidAntal { get; private set; }
        public double sidLängd { get; private set; }

        public Heptagon()
        {
            area = GetArea();
            sidLängd = GetLängdAvSida();
        }
    }
}
