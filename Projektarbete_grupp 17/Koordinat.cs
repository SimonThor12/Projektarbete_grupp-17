using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Koordinat
    {
        public double y;
        public double x;

        public Koordinat (string inputx, string inputy)
        {
            y= double.Parse(inputy);
            x = double.Parse(inputx);
        }


    }
}
