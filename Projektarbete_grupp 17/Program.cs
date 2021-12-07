using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //HandleInput1 punkterInput = new HandleInput1("1,2, ; 3,5,7 ; 5,7,89");
            HandleInput3 ShapescoreInput = new HandleInput3("SQUARE,5;CIRCLE,10");
            HandleInput2 FormerInput = new HandleInput2("SQUARE,5,3,10;CIRCLE,1,1,12", ShapescoreInput);
            HandleInput1 Input1 = new HandleInput1("1,1,5");
            HandleAllInput input = new HandleAllInput(Input1, FormerInput, ShapescoreInput);
            HämtalTotalPoäng TotalPoäng = new HämtalTotalPoäng(input);
            Console.WriteLine(TotalPoäng.KalkTotalPoäng());
            
         

        }
    }
}
