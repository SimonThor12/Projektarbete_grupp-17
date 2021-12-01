using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Form
    {
        public double Radie { get; private set; }
        public Koordinat koordinat { get; private set; }
        public Cirkel cirkel { get; private set; }
        public int shapeScore { get; private set; }
        public Form (string form, int x, int y, int omkrets, int shapeScore)
        {
            if(form == "CIRCLE")
            {
                cirkel = new Cirkel("cirkel", x,y,omkrets);
                this.shapeScore = shapeScore;

            }
        }
        public void IsInside ()
        {

        }
    }
}
