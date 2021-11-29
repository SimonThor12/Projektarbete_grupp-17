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
        
        public int x1;
        public int y1;
        public int s1;
        public int x2;
        public int y2;
        public int s2;

        public HandleInput1(string arg1)
        {
            arg1Array = arg1.Split(";");

            if (arg1.ToArray().Length == 1 && arg1.Contains(";"))
            {

            }
            else
            {
                Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
            }

            if (arg1Array.Length == 1)
            {
                string punkt1 = arg1Array[0].Trim();

                string[] punkt1Values = punkt1.Split(",");

                //Felhantering
                if (punkt1Values.Length<3 || punkt1Values.Length>3)
                {

                }

                        //Värden för punkt 1
                         x1 = Convert.ToInt32(punkt1Values[0]);
                         y1 = Convert.ToInt32(punkt1Values[1]);
                         s1 = Convert.ToInt32(punkt1Values[2]);
            }
            else if (arg1Array.Length == 2)
            {
                string punkt1 = arg1Array[0].Trim();
                string punkt2 = arg1Array[1].Trim();

                string[] punkt1Values = punkt1.Split(",");
                string[] punkt2Values = punkt2.Split(",");

                        //Värden för punkt 1
                        x1 = Convert.ToInt32(punkt1Values[0]);
                        y1 = Convert.ToInt32(punkt1Values[1]);
                        s1 = Convert.ToInt32(punkt1Values[2]);
                

                        //Värden för punkt 2
                        x2 = Convert.ToInt32(punkt2Values[0]);
                        y2 = Convert.ToInt32(punkt2Values[1]);
                        s2 = Convert.ToInt32(punkt2Values[2]);
                }

            }


        }

        

        

        
        
    }
        
    

