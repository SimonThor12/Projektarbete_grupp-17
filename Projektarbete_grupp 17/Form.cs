using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    abstract class Form
    {
        
        public double Radie { get; private set; }
        protected Koordinat mittpunkt { get; set; }

        protected int antalSidor;

        public string formtyp { get; set; }
        
        public int shapeScore { get; private set; }
        public Form (string formtyp, Koordinat _koordinat, double omkrets, int shapeScore, int antalSidor)
        {
            this.antalSidor = antalSidor;
            this.formtyp = formtyp;
            mittpunkt = _koordinat;
        }
        
        public virtual bool IsInside (Koordinat punkt)
        {
            return true;
        }

        public virtual double GetArea()
        {
            return 0;
        }
       
    }
}
