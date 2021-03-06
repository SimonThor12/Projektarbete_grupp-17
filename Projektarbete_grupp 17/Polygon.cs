using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Polygon : Form
    {
        private int antalsidor;
        private double perimeter;

        private List<Koordinat> vertices = new List<Koordinat>();

        private double offset;

        private double längdavsida;

        private double angle;

       

        public Polygon (string formtyp, Koordinat _mittpunkt, double omkrets, int antalSidor) 
            : base(formtyp, _mittpunkt, omkrets)
        {
            perimeter = omkrets;
            antalsidor = antalSidor;
            mittpunkt = _mittpunkt;
            angle = (Math.PI * 2) / antalsidor;

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
                double X = mittpunkt.x + GetRadie() * Math.Sin(i * angle + offset);
                double Y = mittpunkt.y + GetRadie() * Math.Cos(i * angle + offset);
                Koordinat nyaKoordinater = new Koordinat(X, Y);
                vertices.Add(nyaKoordinater);
            }
        }
        
        public override bool IsInside (Koordinat punkt)
        {
            GetKoordinaterFörHörn();
            double X = punkt.x;
            double Y = punkt.y;
            int j = antalsidor - 1;
            bool IS_HIT = false;

            for (int i = 0; i < antalsidor; i++)
            {
                if(vertices[i].y < Y && vertices[j].y >= Y || vertices[j].y < Y && vertices[i].y >= Y )
                {
                    if (vertices[i].x + (Y-vertices[i].y / (vertices[j].y - vertices[i].y) * (vertices[j].x - vertices[i].y)) < X )
                    {
                        IS_HIT = !IS_HIT;
                        return IS_HIT;
                    }
                }
                j = i;


            }
            return IS_HIT;
        }
        
        public override double GetArea()
        {
                       
                double area = 0.5 * GetApothem() * GetLängdAvSida() * antalsidor;
                return area;
            
        }

        public double GetLängdAvSida()
        {
            längdavsida = perimeter / antalsidor;
            return längdavsida;
        }
        public override double GetRadie()
        {
            //double apothem = (längdavsida / 2) / Math.Tan(Math.PI / antalsidor);


            double radie = GetApothem() / Math.Cos(Math.PI / antalsidor);
            return radie;

            // räkna ut apothem med hjälp av trianglar:
            //  |\
            // a| \ b
            //  |__\
            //    c
            //a = apothem


        }
        public double GetApothem()
        {
            //double apothem = (längdavsida / 2) / Math.Tan(Math.PI / antalsidor);


                double apothem = (GetLängdAvSida() / 2) / (Math.Tan(Math.PI / antalsidor));
                return apothem;
    
            // räkna ut apothem med hjälp av trianglar:
            //  |\
            // a| \ b
            //  |__\
            //    c
            //a = apothem

         
        }

    }
}
