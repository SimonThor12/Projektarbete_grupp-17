using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Pentagon: Polygon
    {
        public int lengthOfSides { get; private set; }
        
        public Pentagon ()
        {

        }
        //double GetArea()
        //{
        //    double area = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(lengthOfSides, 2);
        //    return area;
        //}
    }
}
