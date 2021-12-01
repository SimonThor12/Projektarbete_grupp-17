using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Cirkel : Form
    {
        public Koordinat koordinater {get; private set; }


        public Cirkel (string form, int x,int y, int omkrets)

        {
           // Radie = perimeter / (2 * Math.PI);
            
            if(input.form1=="CIRCLE")
            {
                koordinater = new Koordinat(input.x1, input.y1);
            }
            if(input.form2 == "CIRCLE")
            {
                koordinater = new Koordinat(input.x2, input.y2);
            }
            if(input.form3 == "CIRCLE")
            {
                koordinater = new Koordinat(input.x3, input.y3);
            }
            if(input.form4 == "CIRCLE")
            {
                koordinater = new Koordinat(input.x4, input.y4);
            }


        }
        
        public double GetArea()
        {
            return Radie * Radie * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2*Radie * Math.PI;
        }

        public bool IsInside (Koordinat punkt)
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
