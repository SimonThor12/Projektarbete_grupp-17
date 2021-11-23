using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Koordinat
    {
        public int y;
        public int x;

        public Koordinat (string inputx, string inputy)
        {
            y= int.Parse(inputy);
            x = int.Parse(inputx);
        }


    }
}
