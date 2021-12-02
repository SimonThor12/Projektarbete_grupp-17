using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Punkt
    {
        List<Koordinat> koordinater;
        Koordinat koordinat;
        List<int> pointScores;

        int pointScore;

        public Punkt (Koordinat koordinat, int score)
        {
            koordinater = punktInputs.GetPunkter();
            pointScores = punktInputs.GetPointScores();
        }
    }
}
