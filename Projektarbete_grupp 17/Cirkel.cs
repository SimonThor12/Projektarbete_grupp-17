using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Cirkel : Form
    {

        public Cirkel(string form, Koordinat mittpunkt, double omkrets, int shapeScore) 
            : base (form, mittpunkt, omkrets, shapeScore, 0)

        {
            // Radie = perimeter / (2 * Math.PI);
        }

        public override double GetArea()
        {
            return Radie * Radie * Math.PI;
            ///
        }

        public double GetPerimeter()
        {
            return 2*Radie * Math.PI;
        }

        public override bool IsInside (Koordinat punkt)
        {
            double x1 = mittpunkt.x;
            double x2 = punkt.x;
            double y1 = mittpunkt.y;
            double y2 = punkt.y;
            double disttopunkt = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            if (disttopunkt<Radie)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
