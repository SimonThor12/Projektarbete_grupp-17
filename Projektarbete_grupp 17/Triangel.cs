using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Triangel : Form
    {
        public double Sida { get; private set; }
        
        public double GetArea()
        { 
            return (Sida * Sida)/ 2;
        }

       
    }
}
