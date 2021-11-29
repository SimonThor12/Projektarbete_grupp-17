using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Fyrkant : Form
    {
        public double Sida { get; private set; }
        public double Omkrets { get; private set; }

        public Koordinat kordinaterFörEnFykant;
        public HandleOutput fyrkanten;

        public double Ymin { get; private set; }
        public double Ymax { get; private set; }
        public double Xmax { get; private set; }
        public double Xmin { get; private set; }

        public double GetArea()
        {
            return Sida * Sida;
        }
        public Fyrkant(int a, int b, double _omkrets)
        {
            kordinaterFörEnFykant = new Koordinat(a, b);
            Sida = _omkrets / 4;
            Xmax = kordinaterFörEnFykant.x + (Sida / 2);
            Xmin = kordinaterFörEnFykant.x - (Sida / 2);
            Ymax = kordinaterFörEnFykant.y + (Sida / 2);
            Ymin = kordinaterFörEnFykant.y - (Sida / 2);
        }
        public bool InnanFörFyrkantKordinat1()
        {

            if (fyrkanten.kordinater1.x < Xmax)
            {
                return true;
            }
            if (fyrkanten.kordinater1.x > Xmin)
            {
                return true;
            }
            if (fyrkanten.kordinater1.y < Ymax)
            {
                return true;
            }
            if (fyrkanten.kordinater1.y > Ymin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InnanFörFyrkantKordinat2()
        {

            if (fyrkanten.kordinater2.x < Xmax)
            {
                return true;
            }
            if (fyrkanten.kordinater2.x > Xmin)
            {
                return true;
            }
            if (fyrkanten.kordinater2.y < Ymax)
            {
                return true;
            }
            if (fyrkanten.kordinater2.y > Ymin)
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
