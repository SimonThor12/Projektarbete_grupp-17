using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1,2,3"
            HandleInput2 cirkel = new HandleInput2("Cirkel, 3, 5, 20");
            HandleInput2 fyrkaten = new HandleInput2("Square, 3, 5, 20");
            HandleOutput fyrnakten = new HandleOutput(fyrkaten);
            Form Cirkel = new Cirkel(cirkel);
            Console.WriteLine("Your input for the points is incorrect.\n" +
                    "It should follow this format: X, Y, SCORE.\n" +
                    "Each point should also be separated with a ‘;’");



        }
    }
}
