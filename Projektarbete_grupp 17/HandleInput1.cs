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

        private int x;
        private int y;
        private int s;
     
        List<Punkt> punktLista = new List<Punkt>();

        public HandleInput1(string arg1)
        {
            arg1Array = arg1.Split(";");
            string[] punktVärden;

            for (int i = 0; i < arg1Array.Length; i++)
            {
                
                punktVärden = arg1Array[i].Split(",");
                for (int j = 0; j < punktVärden.Length; j++)
                {
                    punktVärden[j] = punktVärden[j].Trim();
                }

                if (arg1Array.Length - 1 == i && arg1Array[i] == "")
                {

                }
                else if (punktVärden.Length != 3)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                    Environment.Exit(0);
                }
                else
                {
                    x = Convert.ToInt32(punktVärden[0]);
                    y = Convert.ToInt32(punktVärden[1]);
                    s = Convert.ToInt32(punktVärden[2]);

                    
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
        
    

