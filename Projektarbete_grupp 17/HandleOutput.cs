using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleOutput 
    {
        public int kordinatSiffra1 { get; private set; }
        public int kordinatSiffra2 { get; private set; }
        
        public void OutPut1()
        {
            HandleInput1 argument1 = new HandleInput1();
            kordinatSiffra1 = argument1.x1;
            kordinatSiffra2 = argument1.y1;
            

            

        }
        public bool InnanFörFyrkant()
        {
            Fyrkant fyrkant = new Fyrkant(3, 4, 20);
            if (kordinatSiffra1 < fyrkant.Xmax)
            {
                return true;
            }
            else if (kordinatSiffra1 > fyrkant.Xmin)
            {
                return true;
            }
            else if (kordinatSiffra2 < fyrkant.Ymax)
            {
                return true;
            }
            else if (kordinatSiffra2 > fyrkant.Ymin)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
    }
}
