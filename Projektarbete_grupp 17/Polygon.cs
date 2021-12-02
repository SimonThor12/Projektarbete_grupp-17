using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Polygon : Form
    {
        public double antalsidor;
        public int perimeter { get; private set; }

        public double apothem { get; private set; }

        Koordinat mittpunkt;

        private double offset;

        public double längdavsida { get; private set; }

        public double angle = Math.PI * 2 / 2;

        public Polygon (string formtyp, Koordinat _mittpunkt, int omkrets, int shapeScore) : base(formtyp, _mittpunkt, omkrets, shapeScore)
        {
            mittpunkt = _mittpunkt;
        }
        public void GetKoordinaterFörHörn()
        {
            if (antalsidor % 2 == 0)
            {
                offset = angle / 2;
            }
            else
            {
                offset = 0;
            }

            for (int i = 0; i < antalsidor; i++)
            {
                double X = mittpunkt.x + GetApothem() * Math.Sin(i * angle + offset);
                double Y = mittpunkt.y + GetApothem() * Math.Cos(i * angle + offset);
            }
        }

//    FOR i = 0 i<ANTALET_SIDOR i++
//    NY_XKOORDINAT = MITTPUNKTENS_XKOORDINAT + CIRCUMRADIUS* SIN(i* ANGLE + OFFSET));
//    NY_YKOORDINAT = MITTPUNKTENS_YKOORDINAT + CIRCUMRADIUS* COS(i* ANGLE + OFFSET));
//    LAGRA DE NYA KOORDINATERN

        
        public double GetArea()
        {
            //Matematisk formel: A = 1/2 * apothem * perimeter

            double area = 0.5 * GetApothem() * perimeter;
            return area;
        }

        public double GetLängdAvSida()
        {
            längdavsida = perimeter / antalsidor;
            return längdavsida;
        }
        public double GetApothem()
        {
            // räkna ut apothem med hjälp av trianglar:
            //  |\
            // a| \ b
            //  |__\
            //    c
            //a = apothem
            
            double c = GetLängdAvSida() / 2;


            double apothem = c * Math.Sqrt(3);
            return apothem;
        }

        public virtual double GetRadie()
        {
            double Radie = Math.Sqrt(Math.Pow(längdavsida / 2, 2) + Math.Pow(apothem, 2));
            return Radie;
        }
    }
}
