using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HandleInput3 ShapescoreInput = new HandleInput3("TRIANGLE,3;SQUARE,5;CIRCLE,10; Octagon,7 ");
            HandleInput2 FormerInput = new HandleInput2("TRIANGLE,0,0,60; CIRCLE, 1,1, 12;SQUARE,5,3,10; OCTAGON, 1,-20, 15", ShapescoreInput);
            HandleInput1 Input1 = new HandleInput1("1,1,5;2,2,10");
            HandleAllInput input = new HandleAllInput(Input1, FormerInput, ShapescoreInput);
            HämtalTotalPoäng TotalPoäng = new HämtalTotalPoäng(input);
            Console.WriteLine(Convert.ToInt32(TotalPoäng.KalkTotalPoäng()));
            
         

        }
    }
}
