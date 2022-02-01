using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HämtalTotalPoäng
    {
        
      //  List<Punkt> punktLista;
       // List<Form> formLista;
      //  Dictionary<string, int> shapeScoreLista;
      private HandleAllInput allInput;

        public HämtalTotalPoäng (HandleAllInput AllInput)
        {
            allInput = AllInput;
        //    this.punktLista = (List<Punkt>)AllInput.punktLista;
         //   this.formLista = (List<Form>)AllInput.formLista;
           // this.shapeScoreLista = (Dictionary<string,int>)AllInput.shapeScoreLista;
            //totalScore = KalkTotalPoäng(former, punkt);
           // int [] pointScoreArray = allInput.GetPointScore();
           
        }

        public double KalkTotalPoäng()
        {
            
            double totalPoäng = 0;

            for (int i = 0; i < allInput.punktLista.Count; i++)
            {
                
                for (int j = 0; j < allInput.formLista.Count; j++)
                {
                    allInput.shapeScoreLista.TryGetValue(allInput.formLista[j].formtyp, out int value);
                    if (allInput.formLista[j].IsInside(allInput.punktLista[i].koordinat))
                    {
                        totalPoäng += allInput.formLista[j].GetArea() + allInput.punktLista[i].pointScore + value;//allInput.GetShapeScore(allInput.formLista[j]);
                    }
                    else if (!allInput.formLista[j].IsInside(allInput.punktLista[i].koordinat))
                    {
                        
                        totalPoäng += ((allInput.formLista[j].GetArea() + value) / 4);//allInput.GetShapeScore(allInput.formLista[j])) / 4;
                    }

                   /* if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "CIRCLE")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForCircle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp=="CIRCLE")
                    {
                        totalPoäng += (formLista[j].GetArea()+allInput.GetShapeScoreForCircle()) / 4;
                    }
        
        
                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "SQUARE")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForSquare();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "SQUARE")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForSquare()) / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "TRIANGLE")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForTriangle();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "TRIANGLE")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForTriangle()) / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "PENTAGON")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForPentagon();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "PENTAGON")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForPentagon()) / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEXAGON")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForHexagon();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEXAGON")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForHexagon()) / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEPTAGON")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForHeptagon();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "HEPTAGON")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForHeptagon()) / 4;
                    }


                    if (formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "OCTAGON")
                    {
                        totalPoäng += formLista[j].GetArea() + punktLista[i].pointScore + allInput.GetShapeScoreForOktagon();
                    }
                    else if (!formLista[j].IsInside(punktLista[i].koordinat) && formLista[j].formtyp == "OCTAGON")
                    {
                        totalPoäng += (formLista[j].GetArea() + allInput.GetShapeScoreForOktagon()) / 4;
                    } */
                }
                
            }
            return totalPoäng;


        }

    }
}
