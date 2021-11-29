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
        public int X { get; private set; }
        public int Y { get; private set; }
        public int perimeter { get; private set; }
        public int shapeScore { get; private set; }
        public Koordinat punktKoordinat1;
        public Koordinat punktKoordinat2;
        public Koordinat koordinatForm1;
        public Koordinat koordinatForm2;
        public Koordinat koordinatForm3;
        public Koordinat koordinatForm4;
        public HandleInput2 argument2;
        public HandleInput1 argument1;
        public HandleInput3 argument3;
        
        public HandleOutput (HandleInput1 input1, HandleInput2 input2, HandleInput3 input3)
        {
            punktKoordinat1 = new Koordinat(input1.x1, input1.y1);
            punktKoordinat2 = new Koordinat(input1.x2, input1.y2);

            koordinatForm1 = new Koordinat(input2.x1, input2.y1);
            koordinatForm2 = new Koordinat(input2.x2, input2.y2);
            koordinatForm3 = new Koordinat(input2.x3, input2.y3);
            koordinatForm4 = new Koordinat(input2.x4, input2.y4);



        }

        public void OutPut1()
        {
            kordinatSiffra1 = argument1.x1;
            kordinatSiffra2 = argument1.y1;
            kordinatSiffra3 = argument1.x2;
            kordinatSiffra4 = argument1.y2;

            pointScore1 = argument1.s1;
            pointScore2 = argument1.s2;
            kordinater1 = new Koordinat(kordinatSiffra1, kordinatSiffra2);
            kordinater2 = new Koordinat(kordinatSiffra3, kordinatSiffra4);



        }
        public HandleOutput(HandleInput2 a)
        {

        }

        public void FormenÄrFyrkant()
        {
            if (argument2.form1 == "Square")
            {
                X = argument2.x1;
                Y = argument2.y1;
                perimeter = argument2.perimeter1;
        
                // shapeScore = argument3.score1;
                OutPut1Fyrkant();

            }
            if(argument2.form2 == "Square")
            {
                X = argument2.x2;
                Y = argument2.y2;
                perimeter = argument2.perimeter2;
                //shapeScore = argument3.score2;
                OutPut1Fyrkant();
            }
            if(argument2.form3 == "Square")
            {
                X = argument2.x3;
                Y = argument2.y3;
                perimeter = argument2.perimeter3;
                //shapeScore = argument3.score3;
                OutPut1Fyrkant();
            }
            if(argument2.form4 == "Square")
            {
                X = argument2.x4;
                Y = argument2.y4;
                perimeter = argument2.perimeter4;
                //shapeScore = argument3.score4;
                OutPut1Fyrkant();
            }
            
        }
        public long OutPut1Fyrkant()
        {

            Fyrkant fyrkanten = new Fyrkant(X, Y, perimeter);
            if (fyrkanten.InnanFörFyrkantKordinat1())
            {
                return (long)fyrkanten.GetArea() * pointScore1 * shapeScore;
            }
            if (fyrkanten.InnanFörFyrkantKordinat2())
            {
                return (long)fyrkanten.GetArea() * pointScore2 * shapeScore;
            }
            else
            {
                return (long)(fyrkanten.GetArea() * shapeScore) / 4;
            }
        }
        /*public long OutPut1Cirkel()
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

        }*/
        


    }
}
