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

        int x;
        int y;

        int omkrets;
        string form;
        List<Form> former;

        //Tar in "Circle,x,y,perimeter  ;  triangle,x,y,perimeter;"

        public HandleInput2 (string arg2)

        {
            arg2Array = arg2.Split(";");

            for (int i = 0; i < arg2Array.Length; i++)
            {
                form = arg2Array[i].Trim();
                string [] formVärden = form.Split(",");

                if (formVärden.Length!=4)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                  " It should follow this format: X, Y, SCORE." +
                  " Each point should also be separated with a ‘;’");
                }
                else
                {

                    form = formVärden[0];
                    x = Convert.ToInt32(formVärden[1]);
                    y = Convert.ToInt32(formVärden[2]);
                    omkrets = Convert.ToInt32(formVärden[3]);


                    former[i] = new Form(form, x, y, omkrets);

                    
                }
            }

            switch (arg2Array.Length)
            {
                case 1:

                    
                  

                    this.form1Koordinater = new Koordinat(x1, y1);

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

                    this.form1Koordinater = new Koordinat(x1, y1);
                    this.form2Koordinater = new Koordinat(x2, y2);



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

                    this.form1Koordinater = new Koordinat(x1, y1);
                    this.form2Koordinater = new Koordinat(x2, y2);
                    this.form3Koordinater = new Koordinat(x3, y3);

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

                    this.form1Koordinater = new Koordinat(x1, y1);
                    this.form2Koordinater = new Koordinat(x2, y2);
                    this.form3Koordinater = new Koordinat(x3, y3);
                    this.form4Koordinater = new Koordinat(x4, y4);


                    break;

            }

           
                
            
        }
       
        
    }
}
