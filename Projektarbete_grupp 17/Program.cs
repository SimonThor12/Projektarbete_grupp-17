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
        }
    }
}
