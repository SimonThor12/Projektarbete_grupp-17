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
        List<ShapeScore> shapeScoreLista;


        public HämtalTotalPoäng (HandleAllInput Input)
        {
            this.punktLista = (List<Punkt>)Input.punktLista;
            this.formLista = (List<Form>)Input.punktLista;
            this.shapeScoreLista = (List<ShapeScore>)Input.shapeScoreLista;
            //totalScore = KalkTotalPoäng(former, punkt);
        }

        public long KalkTotalPoäng ()
        {
            
        }
        public long OutPut1Cirkel(Form formen, Koordinat punkten)
        {
            if (formen.cirkel.IsInside(punkten))
            {
                return (long)formen.cirkel.GetArea() * punkten.pointScore * formen.shapeScore;
            }
            else
            {
                return (long)(formen.cirkel.GetArea() * formen.shapeScore) / 4;
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
