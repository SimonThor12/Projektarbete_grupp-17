using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput3
    {
        public string[] arg3Array;

        private string form;
        private int score;

        private string shapeScore;

        public Dictionary<string, int> shapeScoresDictionary = new Dictionary<string, int>();
        public HandleInput3(string arg3)
        {
            arg3Array = arg3.Split(";");

            for (int i = 0; i < arg3Array.Length; i++)
            {
                shapeScore = arg3Array[i].Trim();
                string [] shapeScoreVärden = shapeScore.Split(",");

                if (shapeScoreVärden.Length != 2)
                {
                    Console.WriteLine("Your input for the scores is incorrect.\n" +
                    " It should follow this format: SHAPE, SHAPE_SCORE." +
                    " Each point should also be separated with a ‘;’");
                }
                else
                {
                    form = shapeScoreVärden[0];
                    score = Convert.ToInt32(shapeScoreVärden[1]);
                    shapeScoresDictionary.Add(form, score);

                }
            }

        }


        public Dictionary<string, int> HandleInput()
        {
            return shapeScoresDictionary;
        }
    }
}
