using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HandleInput3 ShapescoreInput = new HandleInput3("SQUARE,5");
            HandleInput2 FormerInput = new HandleInput2("SQUARE,5,3,10", ShapescoreInput);
            HandleInput1 Input1 = new HandleInput1("1,1,5");
            HandleAllInput input = new HandleAllInput(Input1, FormerInput, ShapescoreInput);
            HämtalTotalPoäng TotalPoäng = new HämtalTotalPoäng(input);
            Console.WriteLine(TotalPoäng.KalkTotalPoäng());
            
         

        }
    }
}
