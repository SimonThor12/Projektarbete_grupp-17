using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Fyrkant : Former
    {
        public double Höjden { get; private set; }
        public double Basen { get; private set; }
        public double GetArea()
        {
            return Höjden * Basen;
        }

        public double GetPerimeter()
        {
            return 2*Höjden + 2*Basen;
        }
    }
}
