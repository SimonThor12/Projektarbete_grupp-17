using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Punkt
    {
        int y;
        int x;
        int pointscore;

        public Punkt (string inputX, string inputY, string _pointscore)
        {
            y = int.Parse(inputY);
            x = int.Parse(inputX);
            pointscore = int.Parse(_pointscore);
        }
    }
}
