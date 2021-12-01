using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HämtalTotalPoäng
    {
        public long OutPut1Cirkel(Cirkel input, Koordinat punkten)
        {
            if (input.IsInside(punkten))
            {
                input.GetArea() * punkten.pointScore * 
            }
        }
    }
}
