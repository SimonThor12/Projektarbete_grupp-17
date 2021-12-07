using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Punkt
    {
        public Koordinat koordinat { get; private set; }

        public int pointScore { get; private set; }

        public Punkt (Koordinat koordinat, int score)
        {
            pointScore = score;
            this.koordinat = koordinat;
        }
    }
}
