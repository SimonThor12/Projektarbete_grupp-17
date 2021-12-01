using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput2
    {
        
        public string[] arg2Array;

        HandleInput3 scores;
        int x;
        int y;

        int omkrets;
        string form;
        public List<Form> formLista;
        int shapeScore;

        //Tar in "Circle,x,y,perimeter  ;  triangle,x,y,perimeter;"
        
        public HandleInput2 (string arg2, HandleInput3 Scores)

        {
            scores = Scores;

            arg2Array = arg2.Split(";");

            for (int i = 0; i < arg2Array.Length; i++)
            {
                form = arg2Array[i].Trim();
                string [] formVärden = form.Split(",");

                if (formVärden.Length!=4)
                {
                    Console.WriteLine("Your input for the points is incorrect.\n" +
                  " It should follow this format: X, Y, SCORE." +
                  " Each point should also be separated with a ‘;’");
                }
                else
                {
                    form = formVärden[0];
                    x = Convert.ToInt32(formVärden[1]);
                    y = Convert.ToInt32(formVärden[2]);
                    omkrets = Convert.ToInt32(formVärden[3]);

                    for (int j = 0; j < scores.shapeScores.Count; j++)
                    {
                        if (form == scores.shapeScores[0].form)
                        {
                            shapeScore = scores.shapeScores[j].score;
                        }
                        
                    }
                    

                    formLista[i] = new Form(form, x, y, omkrets, shapeScore);
                }
            }
        }
       
        
    }
}
