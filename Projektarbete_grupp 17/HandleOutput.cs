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
            HandleInput argument1 = new HandleInput();
            kordinatSiffra1 = argument1.x1;
            kordinatSiffra2 = argument1.y1;
            Koordinat _argument1 = new Koordinat(kordinatSiffra1, kordinatSiffra2);
        }   
    }
}
