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

        public int GetShapeScore ()
        {
            foreach (Form form in formLista)
            {

                if (shapeScoreLista.TryGetValue("CIRCLE", out int circlevalue) && form.formtyp == "CIRCLE")
                {
                    return circlevalue;
                }
                if (shapeScoreLista.TryGetValue("SQUARE", out int squarevalue) && form.formtyp == "SQUARE")
                {
                    return squarevalue;
                }
                if (shapeScoreLista.TryGetValue("TRIANGLE", out int trianglevalue) && form.formtyp == "TRIANGLE")
                {
                    return trianglevalue;
                }
                if (shapeScoreLista.TryGetValue("PENTAGON", out int pentagonvalue) && form.formtyp == "PENTAGON")
                {
                    return pentagonvalue;
                }
                if (shapeScoreLista.TryGetValue("HEXAGON", out int hexagonvalue) && form.formtyp == "HEAXGON")
                {
                    return hexagonvalue;
                }

                if (shapeScoreLista.TryGetValue("HEPTAGON", out int heptagonvalue) && form.formtyp == "HEPTAGON")
                {
                    return heptagonvalue;
                }

                if (shapeScoreLista.TryGetValue("OCTAGON", out int octagonvalue) && form.formtyp == "OCTAGON")
                {
                    return octagonvalue;
                }
                else
                {
                    return 0;
                }
            }
            return 0;

        }



        public void GetPunkterFrånLista ()
        {
            for (int i = 0; i < punktLista.Count; i++)
            {
                
            }
        }

        public void GetFormerFrånLista ()
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
