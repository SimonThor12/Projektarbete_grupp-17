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
        int s1;
        int x2;
        int y2;
        int s2;
        public List<Koordinat> punktLista;

        public HandleInput1(string arg1)
        {
            arg1Array = arg1.Split(";");

            for (int i = 0; i < arg1Array.Length; i++)
            {
                punkt = arg1Array[i].Trim();
                string[] punktVärden = punkt.Split(",");
                if (punktVärden.Length != 3)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                }
                else
                {
                    x1 = Convert.ToInt32(punktVärden[0]);
                    y1 = Convert.ToInt32(punktVärden[1]);
                    s1 = Convert.ToInt32(punktVärden[2]);

                    punktLista[i] = new Koordinat(x1, y1, s1);
                }
            }

            
            

        }


    }

        

        

        
        
}
        
    

