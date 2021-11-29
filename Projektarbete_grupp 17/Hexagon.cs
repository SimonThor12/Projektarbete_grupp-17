using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Hexagon: Polygon
    {
        public int lengthOfSides { get; private set; }
        double GetPerimeter()
        {
            int perimeter = 6 * lengthOfSides;
            return perimeter;
        }
        //double GetArea()
        //{
        //    double area = 3 * Math.Sqrt(3) / 2 * Math.Pow(5, 2);
        //    return area;
        //}
    }
}
