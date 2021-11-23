using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    //fisk i koden
    abstract class Polygon: Former
    {
        public int antalsidor { get; private set; }

        public int perimeter { get; private set; }

        public double apothem { get; private set; }

        public double längdavsida { get; private set; }

        public Polygon (int x, int y, int Perimeter, int antalsidor)
        {
            perimeter = Perimeter;
            //Ta in input
        }
        public double GetArea()
        {
            //Matematisk formel: A = 1/2 * apothem * perimeter

            double area = 0.5 * GetApothem() * perimeter;
            return area;
        }

        public double GetLängdAvSida()
        {
            längdavsida = perimeter / antalsidor;
            return längdavsida;
        }
        public double GetApothem()
        {
            // räkna ut apothem med hjälp av trianglar:
            //  |\
            // a| \ b
            //  |__\
            //    c
            //a = apothem
            
            double c = GetLängdAvSida() / 2;


            double apothem = c * Math.Sqrt(3);
            return apothem;
        }

        public 
    }
}
