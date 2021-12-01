using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class ShapeScore
    {
        HandleInput2 input;
        public string form;
        public int score;

        public ShapeScore (string Form, int Score, HandleInput2 Input)
        {
            form = Form;
            score = Score;
            input = Input;
        }

        

    }
}
