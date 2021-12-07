using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleAllInput

    {
        public List<Punkt> punktLista { get; private set; }
        public List<Form> formLista { get; private set; }
        public Dictionary<string,int> shapeScoreLista { get; private set; }
        public HandleAllInput(IHandler<Punkt> punktLista, IHandler<Form> formLista, HandleInput3 shapeScore)
        {
            this.punktLista = punktLista.HandleInput();
            this.formLista = formLista.HandleInput();
            this.shapeScoreLista = shapeScore.HandleInput();
            
        }

        public int GetShapeScoreForSquare()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("SQUARE", out int squarevalue) && form.formtyp == "SQUARE")
                {
                    return squarevalue;
                }
            }
            return 0;

        }
        public int GetShapeScoreForTriangle()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("TRIANGLE", out int squarevalue) && form.formtyp == "TRIANGLE")
                {
                    return squarevalue;
                }
            }
            return 0;

        }
        public int GetShapeScoreForPentagon()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("PENTAGON", out int pentagonvalue) && form.formtyp == "PENTAGON")
                {
                    return pentagonvalue;
                }
            }
            return 0;

        }
        public int GetShapeScoreForHexagon()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("HEXAGON", out int pentagonvalue) && form.formtyp == "HEXAGON")
                {
                    return pentagonvalue;
                }
            }
            return 0;

        }
        public int GetShapeScoreForHeptagon()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("HEPTAGON", out int heptagonvalue) && form.formtyp == "HEPTAGON")
                {
                    return heptagonvalue;
                }
            }
            return 0;

        }
        public int GetShapeScoreForOktagon()
        {
            foreach (Form form in formLista)
            {
                if (shapeScoreLista.TryGetValue("OCTAGON", out int octagonvalue) && form.formtyp == "OCTAGON")
                {
                    return octagonvalue;
                }
            }
            return 0;

        }

        public int GetShapeScoreForCircle()
        { 
            foreach (Form form in formLista)
            {

                if (shapeScoreLista.TryGetValue("CIRCLE", out int circlevalue) && form.formtyp == "CIRCLE")
                {
                    return circlevalue;
                }
            }
            return 0;

        }
        public int[] GetPointScore()
        {
            int[] arr = new int[2];
            int index = 0;
            foreach(Punkt punkten in punktLista)
            {
                int i = 0;
                if(formLista[i].IsInside(punkten.koordinat))
                arr[index] += punkten.pointScore;
                index++;
                i++;

            }
            return arr;
        }





        public void GetFormerFrånLista()
        {
            for (int i = 0; i < formLista.Count; i++)
            {
                switch (formLista[i].formtyp)
                {
                    case "CIRCLE":



                        break;

                    case "SQUARE":




                        break;
                    case "TRIANGLE":



                        break;
                    case "PENTAGON":



                        break;

                    case "HEXAGON":


                        break;

                    case "HEPTAGON":



                        break;


                    case "OCTAGON":



                        break;
                }
            }


        }
        
    }
}
