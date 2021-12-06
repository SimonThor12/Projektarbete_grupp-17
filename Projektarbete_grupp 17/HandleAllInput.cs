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
