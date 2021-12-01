using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Form
    {
        HandleInput2 former;
        public double Radie { get; private set; }
        public Koordinat koordinat { get; private set; }
        public Cirkel cirkel { get; private set; }
        public Fyrkant fyrkant { get; private set; }
        public int shapeScore { get; private set; }
        public Form (string form, int x, int y, int omkrets, int shapeScore)
        {
            
        }
        public void IsInside ()
        {

        }
    }
}
