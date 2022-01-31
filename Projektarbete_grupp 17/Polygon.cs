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
        public double perimeter { get; private set; }

        public List<Koordinat> vertices = new List<Koordinat>();

        public double apothem { get; private set; }

        private double offset;

        public double längdavsida { get; private set; }

        public double angle;

        public Polygon (string formtyp, Koordinat _mittpunkt, double omkrets, int shapeScore, int antalSidor) 
            : base(formtyp, _mittpunkt, omkrets, shapeScore, antalSidor)
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

            for (int i = 1; i < antalsidor; i++)
            {
                double X = mittpunkt.x + GetApothem() * Math.Sin(i * angle + offset);
                double Y = mittpunkt.y + GetApothem() * Math.Cos(i * angle + offset);
                Koordinat nyaKoordinater = new Koordinat(X, Y);
                vertices.Add(nyaKoordinater);
            }
        }
        
        public override bool IsInside (Koordinat punkt) 
        {
            GetKoordinaterFörHörn();
            double X = punkt.x;
            double Y = punkt.y;
            int j = vertices.Count - 1;
            bool IS_HIT = false;

            for (int i = 0; i < vertices.Count; i++)
            {
                if(vertices[i].y < Y && vertices[j].y <= Y || vertices[j].y < Y && vertices[i].y >= Y )
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
