using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    abstract class Form
    {
        HandleInput2 formListaInput;
        public double Radie { get; private set; }
        Koordinat mittpunkt { get; private set; }

        string namn;
        
        public int shapeScore { get; private set; }
        public Form (string form, Koordinat _koordinat, int omkrets, int shapeScore)
        {
            koordinat = _koordinat;
        }


        
        public virtual bool IsInside (Koordinat punkt)
        {

        }
    }
}
