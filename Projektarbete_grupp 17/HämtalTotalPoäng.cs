using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HämtalTotalPoäng
    {
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
            
        }
    }
}
