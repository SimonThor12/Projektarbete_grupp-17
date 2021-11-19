using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Cirkel : Former
    {
        public double Radie { get; private set; }
        public double GetArea()
        {
            return Radie * Radie * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2*Radie * Math.PI;
        }
    }
}
