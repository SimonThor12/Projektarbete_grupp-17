using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput
    {
        public string[] arg1Array;
        public string[] arg2Array;
        public string[] arg3Array;
        
        public HandleInput(string arg1, string arg2, string arg3)
        {
            arg1Array = arg1.Split(";");
            if (arg1Array.Length == 1)
            {
                
                string punkt1 = arg1Array[0];
                
                string[] punkt1Values = punkt1.Split(",");
                for (int i = 0; i < punkt1Values.Length; i++)
                {
                    int x1 = Convert.ToInt32(punkt1Values[0]);
                    int y1 = Convert.ToInt32(punkt1Values[1]);
                    int s1 = Convert.ToInt32(punkt1Values[2]);
                }

               
            }
            else if (arg1Array.Length == 2)
            {
                string punkt1 = arg1Array[0];
                string punkt2 = arg1Array[1];

                string[] punkt1Values = punkt1.Split(",");
                string[] punkt2Values = punkt2.Split(",");

                int x1 = Convert.ToInt32(punkt1Values[0]);
                int y1 = Convert.ToInt32(punkt1Values[1]);
                int s1 = Convert.ToInt32(punkt1Values[2]);

                int x2 = Convert.ToInt32(punkt2Values[0]);
                int y2 = Convert.ToInt32(punkt2Values[1]);
                int s2 = Convert.ToInt32(punkt2Values[2]);
            }
                    
            
        }

        

        

        
        
    }
        
    
}
