using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Polygon : Form
    {
        public int antalsidor;
        public int perimeter { get; private set; }

        List<Koordinat> vertices;

        public double apothem { get; private set; }

        private double offset;

        public double längdavsida { get; private set; }

        public double angle = Math.PI * 2 / 2;

        public Polygon (string formtyp, Koordinat _mittpunkt, int omkrets, int shapeScore, int antalSidor) 
            : base(formtyp, _mittpunkt, omkrets, shapeScore, antalSidor)
        {
            perimeter = omkrets;
            antalsidor = antalSidor;
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
                Koordinat nyaKoordinater = new Koordinat(X, Y);
                vertices.Add(nyaKoordinater);
            }
        }
        
        public override bool IsInside (Koordinat punkt) 
        {
            double X = punkt.x;
            double Y = punkt.y;
            int j = antalsidor - 1;
            bool IS_HIT = false;

            for (int i = 0; i < antalsidor; i++)
            {
                if(vertices[i].y < Y && vertices[j].y <= Y || vertices[j].y < Y && vertices[i].y >= Y )
                {
                    if (vertices[i].x + (Y-vertices[i].y / (vertices[j].y - vertices[i].y) * (vertices[j].x - vertices[i].y)) < X ) 
                    {
                        IS_HIT = !IS_HIT;
                    }
                }
                j = i;
                
            }
            return IS_HIT;
        }
        
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
