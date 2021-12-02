using System;

namespace Projektarbete_grupp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //HandleInput1 punkterInput = new HandleInput1("1,2, ; 3,5,7 ; 5,7,89");
            HandleInput3 ShapescoreInput = new HandleInput3("CIRCLE,100; TRIANGLE,500;");
            HandleInput2 FormerInput = new HandleInput2("CIRCLE,2,3,100", ShapescoreInput);
            HandleAllInput input = new HandleAllInput(new IHandler<T>("1, 2, 5"), new HandleInput2("CIRCLE,2,3,100", ShapescoreInput), new HandleInput3("CIRCLE,100; TRIANGLE,500;"));

            //Koordinat kordinat = new Koordinat(3, 6);

            
            //Polygon ;

            //Cirkel cirkel = new Cirkel(Former);
            //Console.WriteLine(cirkel.IsInside(kordinat));
            //HandleInput2 fyrkaten = new HandleInput2("Square, 3, 5, 20");
            //HandleOutput fyrnakten = new HandleOutput(punkter, Former, Shapescore);

        }
    }
}
