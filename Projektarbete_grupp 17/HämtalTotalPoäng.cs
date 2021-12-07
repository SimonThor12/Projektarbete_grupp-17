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
            allInput.GetPointScore();

        }

       public long KalkTotalPoäng ()
        {
            
                return allInput.GetAreaForUsedShapes() + POINTSCORE + allInput.GetShapeScoreForCircle();
            
            else
            {
                return (long)(formen.cirkel.GetArea() + allInput.GetShapeScoreForCircle()) / 4;
            }
        }
       
            

            //}
            //public long OutPut1Fyrkant(Form formen, Koordinat punkten)
            //{
            //    if (formen.fyrkant.InnanFörFyrkantKordinat(punkten))
            //    {
            //        return (long)formen.fyrkant.GetArea() * punkten.pointScore * formen.shapeScore;
            //    }
            //    else
            //    {
            //        return (long)(formen.fyrkant.GetArea() * formen.shapeScore) / 4;
            //    }
            //}
        }
}
