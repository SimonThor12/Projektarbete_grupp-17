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
            if (arg1Array.Length == 1)
            {
                string punkt1 = arg1Array[0].Trim();

                string[] punkt1Values = punkt1.Split(",");
                for (int i = 0; i < punkt1Values.Length; i++)
                {
                         x1 = Convert.ToInt32(punkt1Values[i]);
                         y1 = Convert.ToInt32(punkt1Values[i]);
                         s1 = Convert.ToInt32(punkt1Values[i]);
                }
            }
            else if (arg1Array.Length == 2)
            {
                string punkt1 = arg1Array[0].Trim();
                string punkt2 = arg1Array[1].Trim();

                string[] punkt1Values = punkt1.Split(",");
                string[] punkt2Values = punkt2.Split(",");

                for (int i = 0; i < punkt1Values.Length; i++)
                {
                        x1 = Convert.ToInt32(punkt1Values[i]);
                        y1 = Convert.ToInt32(punkt1Values[i]);
                        s1 = Convert.ToInt32(punkt1Values[i]);
                }

                for (int i = 0; i < punkt2Values.Length; i++)
                {
                        x2 = Convert.ToInt32(punkt2Values[i]);
                        y2 = Convert.ToInt32(punkt2Values[i]);
                        s2 = Convert.ToInt32(punkt2Values[i]);
                }



            }


        }

        

        

        
        
    }
        
    
}
