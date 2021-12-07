using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HämtalTotalPoäng
    {
        long totalScore;
        List<Punkt> punktLista;
        List<Form> formLista;
        Dictionary<string, int> shapeScoreLista;
        HandleAllInput allInput;

        public HämtalTotalPoäng (HandleAllInput AllInput)
        {
            allInput = AllInput;
            this.punktLista = (List<Punkt>)AllInput.punktLista;
            this.formLista = (List<Form>)AllInput.formLista;
            this.shapeScoreLista = (Dictionary<string,int>)AllInput.shapeScoreLista;
            //totalScore = KalkTotalPoäng(former, punkt);
            int [] pointScoreArray = allInput.GetPointScore();

        }

       public double KalkTotalPoäng ()
        {
            for (int i = 0; i < punktLista.Count; i++)
            {
                if (formLista[i].IsInside(punktLista[i].koordinat) && formLista[i].formtyp == "CIRCLE")
                {
                    return allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                }
                if (formLista[i].IsInside(punktLista[i].koordinat) && formLista[i].formtyp == "SQUARE")
                {
                    return allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                }

                else
            {
                return (long)(formen.cirkel.GetArea() + allInput.GetShapeScoreForCircle()) / 4;
            }
        }
          
        }
       
            

        }
}
