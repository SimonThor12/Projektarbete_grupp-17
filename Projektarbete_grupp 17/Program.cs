using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string kommando = "1,1,5;2,2,10";

            string figur = "Circle,5,3,100";

            string[] arrKommand = kommando.Split(";");
            string nykommand1 = arrKommand[0];
            string nykommand2 = arrKommand[1];

            string[] arrNyKommand = nykommand1.Split(",");
            string _ny1Kommand1 = arrNyKommand[0];
            string _ny2Kommand2 = arrNyKommand[1];
            string _ny3Kommand3 = arrNyKommand[2];

            
            

        }
    }
}
