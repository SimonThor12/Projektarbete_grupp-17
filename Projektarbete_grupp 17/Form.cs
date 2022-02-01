using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    abstract class Form
    {

        public double Radie { get; set; }
        protected Koordinat mittpunkt { get; set; }

        public string formtyp { get; set; }

        
        public Form (string formtyp, Koordinat _koordinat, double omkrets)
        {
            this.formtyp = formtyp;
            mittpunkt = _koordinat;
            Radie = omkrets / (2 * Math.PI);
        }
        
        public virtual bool IsInside (Koordinat punkt)
        {
            return true;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetRadie ()
        {
            return Radie;
        }
    }
}
