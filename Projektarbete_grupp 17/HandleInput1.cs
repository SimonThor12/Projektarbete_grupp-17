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

            if (arg1Array.Length == 1)
            {
                string punkt1 = arg1Array[0].Trim();

                string[] punkt1Values = punkt1.Split(",");

                //Felhantering
                if (punkt1Values.Length!=3)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                }

                        //Värden för punkt 1
                         x1 = Convert.ToInt32(punkt1Values[0]);
                         y1 = Convert.ToInt32(punkt1Values[1]);
                         s1 = Convert.ToInt32(punkt1Values[2]);

                         this.punkt1 = new Koordinat(x1, y1);

            }
            else if (arg1Array.Length == 2)
            {
                string punkt1 = arg1Array[0].Trim();
                string punkt2 = arg1Array[1].Trim();

                string[] punkt1Values = punkt1.Split(",");
                string[] punkt2Values = punkt2.Split(",");

                //Felhantering
                if (punkt1Values.Length!=3 || punkt2Values.Length!=3)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                }
                
                        //Värden för punkt 1
                x1 = Convert.ToInt32(punkt1Values[0]);
                y1 = Convert.ToInt32(punkt1Values[1]);
                s1 = Convert.ToInt32(punkt1Values[2]);

                this.punkt1 = new Koordinat(x1, y1);

                //Värden för punkt 2
                x2 = Convert.ToInt32(punkt2Values[0]);
                y2 = Convert.ToInt32(punkt2Values[1]);
                s2 = Convert.ToInt32(punkt2Values[2]);

                this.punkt2 = new Koordinat(x2, y2);

            }

        }


    }

        

        

        
        
}
        
    

