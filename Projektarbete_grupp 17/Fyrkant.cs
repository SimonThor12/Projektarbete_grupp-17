using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Fyrkant : Former
    {
        public double Sida { get; private set; }

        public double GetArea()
        {
            return Sida * Sida;
        }


    }
}
