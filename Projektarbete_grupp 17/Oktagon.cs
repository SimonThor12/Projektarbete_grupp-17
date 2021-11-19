using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Oktagon : Former
    {
        public int sidAntal { get; private set; }
        public int sidLängd { get; private set; }

        public Oktagon ()
        {

        }
        double GetArea()
        {
            int area = 1/4*sidAntal*Math.Pow(sidLängd,2) + 
        }
            
        double GetPerimeter()
        {
            int perimeter = sidAntal * sidLängd;
            return perimeter;
        } 
            
    }
}
