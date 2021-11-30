using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput1
    {
        public string[] arg1Array;

        string punkt;
        int x1;
        int y1;
        public int s1;
        int x2;
        int y2;
        public int s2;
        public Koordinat punkt1;
        public Koordinat punkt2;
        public HandleInput1(string arg1)
        {
            arg1Array = arg1.Split(";");

            List<Koordinat> PointArray = new List<Koordinat>();

            for (int i = 0; i < arg1Array.Length; i++)
            {
                punkt = arg1Array[i].Trim();
                string[] pointValues = punkt.Split(",");
                if (pointValues.Length != 3)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                }
                else
                {
                    x1 = Convert.ToInt32(pointValues[0]);
                    y1 = Convert.ToInt32(pointValues[1]);
                    s1 = Convert.ToInt32(pointValues[2]);

                    PointArray[i] = new Koordinat(x1, y1);
                }
               

            }

            
            

        }


    }

        

        

        
        
}
        
    

