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

        public double KalkTotalPoäng()
        {
            double totalPoäng = 0;

            for (int i = 0; i < punktLista.Count; i++)
            {
                for (int j = 0; j < formLista.Count; j++)
                {
                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "CIRCLE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp=="CIRCLE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes()+allInput.GetShapeScoreForCircle() / 4;
                    }
        
        
                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "SQUARE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "SQUARE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "TRIANGLE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "TRIANGLE")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "PENTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "PENTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEXAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEXAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEPTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEPTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "OCTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "OCTAGON")
                    {
                        totalPoäng += allInput.GetAreaForUsedShapes() + allInput.GetShapeScoreForCircle() / 4;
                    }
                }
                
            }
            return totalPoäng;


        }

    }
}
