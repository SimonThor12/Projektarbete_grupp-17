﻿using System;
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
        public Koordinat kordinater;
        
        public void OutPut1()
        {
            HandleInput1 argument1 = new HandleInput1();
            kordinatSiffra1 = argument1.x1;
            kordinatSiffra2 = argument1.y1;

            kordinater = new Koordinat(kordinatSiffra1, kordinatSiffra2);
            

        }
        


    }
}
