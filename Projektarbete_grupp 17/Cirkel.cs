using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Cirkel : Form
    {

        public Cirkel(string form, Koordinat koordinat, int omkrets) : base (form, koordinat, omkrets, )

        {
            // Radie = perimeter / (2 * Math.PI);




        }

        public double GetArea()
        {
            return Radie * Radie * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2*Radie * Math.PI;
        }

        public override bool IsInside (Koordinat punkt)
        {
            double x1 = koordinater.x;
            double x2 = punkt.x;
            double y1 = koordinater.y;
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
