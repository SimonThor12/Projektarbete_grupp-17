using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput1: IHandler<Punkt>
    {
        public string[] arg1Array;

        string punkt;
        int x;
        int y;
        int s;
     
        List<Punkt> punktLista = new List<Punkt>();

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
                    x = Convert.ToInt32(punktVärden[0]);
                    y = Convert.ToInt32(punktVärden[1]);
                    s = Convert.ToInt32(punktVärden[2]);

                    //Notera att Koordinat och poäng för denna koordinat har samma index men för olika listor
                    punktLista.Add(new Punkt(new Koordinat(x,y), s));

                }
            }

            
            

        }

        public List<Punkt> HandleInput()
        {
            return punktLista; 
        }
    }

        

        

        
        
}
        
    

