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
        public string form1;
        public string form2;
        public string form3;
        public string form4;

        public int x1;
        public int x2;
        public int x3;
        public int x4;

        public int y1;
        public int y2;
        public int y3;
        public int y4;

        public int perimeter1;
        public int perimeter2;
        public int perimeter3;
        public int perimeter4;

        string [] form1Values;
        string[] form2Values;
        string[] form3Values;
        string[] form4Values;



        //Tar in "Circle,x,y,perimeter  ;  triangle,x,y,perimeter;"
        public HandleInput2 (string arg2)

        {
            arg2Array = arg2.Split(";");
          

            switch (arg2Array.Length)
            {
                case 1:

                    string form1trim = arg2Array[0].Trim();
                    form1Values = form1trim.Split(",");
                    
                    form1 = form1Values[0];
                    x1 = Convert.ToInt32(form1Values[1]);
                    y1 = Convert.ToInt32(form1Values[2]);
                    perimeter1 = Convert.ToInt32(form1Values[3]);

                    break;

                case 2:

                    form1trim = arg2Array[0].Trim();
                    form1Values = form1trim.Split(",");

                    string form2trim = arg2Array[1].Trim();
                    form2Values = form2trim.Split(",");



                    form1 = form1Values[0];
                    x1 = Convert.ToInt32(form1Values[1]);
                    y1 = Convert.ToInt32(form1Values[2]);
                    perimeter1 = Convert.ToInt32(form1Values[3]);

                    form2 = form2Values[0];
                    x2 = Convert.ToInt32(form2Values[1]);
                    y2 = Convert.ToInt32(form2Values[2]);
                    perimeter2 = Convert.ToInt32(form2Values[3]);


                    break;
                case 3:

                    form1trim = arg2Array[0].Trim();
                    form1Values = form1trim.Split(",");

                    form2trim = arg2Array[1].Trim();
                    form2Values = form2trim.Split(",");

                    string form3trim = arg2Array[2].Trim();
                    form3Values = form3trim.Split(",");



                    form1 = form1Values[0];
                    x1 = Convert.ToInt32(form1Values[1]);
                    y1 = Convert.ToInt32(form1Values[2]);
                    perimeter1 = Convert.ToInt32(form1Values[3]);

                    form2 = form2Values[0];
                    x2 = Convert.ToInt32(form2Values[1]);
                    y2 = Convert.ToInt32(form2Values[2]);
                    perimeter2 = Convert.ToInt32(form2Values[3]);

                    form3 = form3Values[0];
                    x3 = Convert.ToInt32(form3Values[1]);
                    y3 = Convert.ToInt32(form3Values[2]);
                    perimeter3 = Convert.ToInt32(form3Values[3]);

                    break;
                case 4:

                    form1trim = arg2Array[0].Trim();
                    form1Values = form1trim.Split(",");

                    form2trim = arg2Array[1].Trim();
                    form2Values = form2trim.Split(",");

                    form3trim = arg2Array[2].Trim();
                    form3Values = form3trim.Split(",");

                    string form4trim = arg2Array[3].Trim();
                    form4Values = form4trim.Split(",");





                    form1 = form1Values[0];
                    x1 = Convert.ToInt32(form1Values[1]);
                    y1 = Convert.ToInt32(form1Values[2]);
                    perimeter1 = Convert.ToInt32(form1Values[3]);

                    form2 = form2Values[0];
                    x2 = Convert.ToInt32(form2Values[1]);
                    y2 = Convert.ToInt32(form2Values[2]);
                    perimeter2 = Convert.ToInt32(form2Values[3]);

                    form3 = form3Values[0];
                    x3 = Convert.ToInt32(form3Values[1]);
                    y3 = Convert.ToInt32(form3Values[2]);
                    perimeter3 = Convert.ToInt32(form3Values[3]);

                    form4 = form4Values[0];
                    x4 = Convert.ToInt32(form4Values[1]);
                    y4 = Convert.ToInt32(form4Values[2]);
                    perimeter4 = Convert.ToInt32(form4Values[3]);

                    break;

            }

           
                
            
        }
       
        
    }
}
