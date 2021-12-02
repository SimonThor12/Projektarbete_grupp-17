using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput3 : IHandler<ShapeScore>
    {
        public string[] arg3Array;

        string form;
        int score;

        string shapeScore;
        public List<ShapeScore> shapeScores = new List<ShapeScore>();
        public Dictionary<string, int> shapeScoresFormer = new Dictionary<string, int>();
        public HandleInput3(string arg3)
        {
            arg3Array = arg3.Split(";");

            for (int i = 0; i < arg3Array.Length; i++)
            {
                shapeScore = arg3Array[i].Trim();
                string [] shapeScoreVärden = shapeScore.Split(",");

                if (shapeScoreVärden.Length != 2)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                    " It should follow this format: X, Y, SCORE." +
                    " Each point should also be separated with a ‘;’");
                }
                else
                {
                    form = shapeScoreVärden[0];
                    score = Convert.ToInt32(shapeScoreVärden[1]);
                    shapeScoresFormer.Add(form, score);
                    shapeScores.Add(new ShapeScore(form, score));
                }
            }

        }

        public List<ShapeScore> HandleInput()
        {
            return shapeScores;
        }
    }
}
