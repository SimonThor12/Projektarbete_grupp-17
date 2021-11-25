using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput2
    {
        public string[] arg2Array;
        string form1;
        string form2;
        string form3;
        string form4;
        int x1;
        int y1;
        int perimeter1;
        int perimeter2;
        int perimeter3;
        int perimeter4;


        public HandleInput2 (string arg2)

        {
            arg2Array = arg2.Split(";");

            switch (arg2Array.Length)
            {
                case 1:

                    string form1 = arg2Array[0];

                    string[] form1Values = form1.Split(",");

                    form1 = form1Values[0].Trim();

                    for (int i = 1; i < form1.Length; i++)
                    {
                            x1 = Convert.ToInt32(form1Values[1]);
                            
                            y1 = Convert.ToInt32(form1Values[2]);
                            
                            perimeter1 = Convert.ToInt32(form1Values[3]);
                    }
                    break;

                case 2:

                    string form2 = arg2Array[0];

                    string[] form2Values = form2.Split(",");

                    form2 = form2Values[0].Trim();

                    for (int i = 1; i < form1.Length; i++)
                    {
                        x1 = Convert.ToInt32(form1Values[1]);

                        y1 = Convert.ToInt32(form1Values[2]);

                        perimeter1 = Convert.ToInt32(form1Values[3]);
                    }
                    break;




            }

           
                
            
        }
       
        
    }
}
