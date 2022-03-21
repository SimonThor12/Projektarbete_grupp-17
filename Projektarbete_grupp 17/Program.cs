using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleInput1 Input1 = new HandleInput1(args[0]);
            HandleInput2 FormerInput = new HandleInput2(args[1]);
            HandleInput3 ShapescoreInput = new HandleInput3(args[2]);
            HandleAllInput input = new HandleAllInput(Input1, FormerInput, ShapescoreInput);
            HämtalTotalPoäng TotalPoäng = new HämtalTotalPoäng(input);
            Console.WriteLine(Convert.ToInt32(TotalPoäng.KalkTotalPoäng()));
            
         

        }
    }
}
