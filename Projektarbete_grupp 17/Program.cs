using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HandleInput3 ShapescoreInput = new HandleInput3("TRIANGLE,3;SQUARE,6");
            HandleInput2 FormerInput = new HandleInput2("TRIANGLE,0,0,60;SQUARE,5,3,10");
            HandleInput1 Input1 = new HandleInput1("1,1;2,2,10");
            HandleAllInput input = new HandleAllInput(Input1, FormerInput, ShapescoreInput);
            HämtalTotalPoäng TotalPoäng = new HämtalTotalPoäng(input);
            Console.WriteLine(Convert.ToInt32(TotalPoäng.KalkTotalPoäng()));
            
         

        }
    }
}
