using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput2
    {
        
        public string[] arg2Array;
        
        int x;
        int y;

        int omkrets;
        string formtyp;
        List<Form> formLista = new List<Form>();
        int shapeScore;

        //Tar in "Circle,x,y,perimeter  ;  triangle,x,y,perimeter;"
        
        public HandleInput2 (string arg2, HandleInput3 shapeShoreInput)

        {
            Form nyForm;
            List<ShapeScore> shapeScores = shapeShoreInput.GetShapeScore();

            arg2Array = arg2.Split(";");
            Koordinat koordinat;

            for (int i = 0; i < arg2Array.Length; i++)
            {
                formtyp = arg2Array[i].Trim();
                string [] formVärden = formtyp.Split(",");

                if (formVärden.Length!=4)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                  " It should follow this format: X, Y, SCORE." +
                  " Each point should also be separated with a ‘;’");
                }
                else
                {
                    formtyp = formVärden[0];
                    x = Convert.ToInt32(formVärden[1]);
                    y = Convert.ToInt32(formVärden[2]);
                    omkrets = Convert.ToInt32(formVärden[3]);
                    koordinat = new Koordinat(x, y);

                    for (int j = 0; j < shapeScores.Count; j++)
                    {
                        if (formtyp == shapeScores[j].form)
                        {
                            shapeScore = shapeScores[j].score;
                        }
                    }
                    switch (formtyp)
                    {
                        case "CIRCLE":

                            antalKanter =
                            nyForm = new Cirkel(formtyp, koordinat, omkrets, shapeScore, antalKanter) ;
                            formLista.Add(nyForm);

                            break;

                        case "SQUARE":

                            nyForm = new Fyrkant(formtyp, koordinat, omkrets, shapeScore);
                            formLista.Add(nyForm);

                            break;
                        

                            nyForm = new Triangel(formtyp, koordinat, omkrets, shapeScore);
                            formLista.Add(nyForm);
                            break;
                        case "TRIANGLE":
                        case "PENTAGON":
                        case "HEXAGON":
                        case "HEPTAGON":
                        case "OCTAGON":

                            nyForm = new Polygon(formtyp, koordinat, omkrets, shapeScore);
                            formLista.Add(nyForm);


                            break;
                    }
                }
            }
        }

        public List<Form> GetFormLista()
        {
            return formLista;
        }


    }
}
