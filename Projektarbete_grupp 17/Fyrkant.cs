using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Fyrkant : Form
    {
        private double Sida;
        

        public Koordinat kordinaterFörEnFykant;


        private double Ymin;
        private double Ymax;
        private double Xmax;
        private double Xmin;

        public override double GetArea()
        {
            return Sida * Sida;
        }
        public Fyrkant(string form,Koordinat koordinat, double omkrets) : base(form, koordinat, omkrets, 4)
        {
            kordinaterFörEnFykant = koordinat;
            Sida = omkrets / 4;
            Xmax = kordinaterFörEnFykant.x + (Sida / 2);
            Xmin = kordinaterFörEnFykant.x - (Sida / 2);
            Ymax = kordinaterFörEnFykant.y + (Sida / 2);
            Ymin = kordinaterFörEnFykant.y - (Sida / 2);
        }
        override public bool IsInside (Koordinat punkt)
        {

            if (punkt.x < Xmax && punkt.x > Xmin && punkt.y < Ymax && punkt.y > Ymin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
