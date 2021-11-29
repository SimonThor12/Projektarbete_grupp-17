using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleOutput 
    {
        public int kordinatSiffra1 { get; private set; }
        public int kordinatSiffra2 { get; private set; }
        public int kordinatSiffra3 { get; private set; }
        public int kordinatSiffra4 { get; private set; }
        public int pointScore1 { get; private set; }
        public int pointScore2 { get; private set; }
        public Koordinat kordinater1;
        public Koordinat kordinater2;
        
        public void OutPut1()
        {
            HandleInput1 argument1 = new HandleInput1();
            kordinatSiffra1 = argument1.x1;
            kordinatSiffra2 = argument1.y1;
            kordinatSiffra3 = argument1.x2;
            kordinatSiffra4 = argument1.y2;

            pointScore1 = argument1.s1;
            pointScore2 = argument1.s2;
            kordinater1 = new Koordinat(kordinatSiffra1, kordinatSiffra2);
            kordinater2 = new Koordinat(kordinatSiffra3, kordinatSiffra4);

        }
        public long OutPut1Fyrkant()
        {
            Fyrkant fyrkanten = new Fyrkant(kordinatSiffra1,kordinatSiffra2, 20);
            if (fyrkanten.InnanFörFyrkant())
            {
                return fyrkanten.GetArea() * pointScore * "shapeScore";
            }
            else
            {
                return (fyrkanten.GetArea() * "shapeScoere") / 4;
            }
        }

        public long OutPut1Cirkel()
        {
            Cirkel cirkeln = new Cirkel(20);
            if (cirkeln.IsInside("fixa senare"))
            {
                return cirkeln.GetArea() * pointScore * "shapeScore";
            }
            else
            {
                return cirkeln.GetArea() * pointScore * "shapeScore";
            }

        }
        


    }
}
