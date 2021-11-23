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
        public double Omkrets { get; private set; }

        public Koordinat kordinater; 
     
        public double Ymin { get; private set; }
        public double Ymax { get; private set; }
        public double Xmax { get; private set; }
        public double Xmin { get; private set; }
        
        public double GetArea()
        {
            return Sida * Sida;
        }
        public Fyrkant(string a, string b, double _omkrets)
        {
            kordinater = new Koordinat(a, b);
            Sida = _omkrets / 4;
            Xmax = kordinater.x + (Sida / 2);
            Xmin = kordinater.x - (Sida / 2);
            Ymax = kordinater.y + (Sida / 2);
            Ymin = kordinater.y - (Sida / 2);
        }

    }
}
