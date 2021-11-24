using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput
    {
        public HandleInput (string Input)
        {

        }
        public string punkt = "1,1,5;2,2,10";

        string figur = "Circle,5,3,100";

        public string[] arrKommand = punkt.Split(";");

        string punkt1 = arrKommand[0];
        string punkt2 = arrKommand[1];

        string[] punktArray = punkt1.Split(",");
        string Xvärde = punktArray[0];
        string Yvärde = punktArray[1];
        string Score = punktArray[2];
    }
}
