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

        public string form1;
        public string form2;
        public string form3;
        public string form4;

        public int score1;
        public int score2;
        public int score3;
        public int score4;

        string[] ShapeScore1Values;
        string[] shapeScore2Values;
        string[] shapeScore3Values;
        string[] shapeScore4Values;

        public HandleInput3(string arg3)
        {
            arg3Array = arg3.Split(";");


                switch (arg3Array.Length)
                {
                    case 1:

                        string shape1trim = arg3Array[0].Trim();
                        ShapeScore1Values = shape1trim.Split(",");

                        form1 = ShapeScore1Values[0];
                        score1 = Convert.ToInt32(ShapeScore1Values[1]);

                        break;

                    case 2:

                        shape1trim = arg3Array[0].Trim();
                        ShapeScore1Values = shape1trim.Split(",");

                        string shape2trim = arg3Array[1].Trim();
                        shapeScore2Values = shape2trim.Split(",");

                        form1 = ShapeScore1Values[0];
                        score1 = Convert.ToInt32(ShapeScore1Values[1]);

                        form2 = shapeScore2Values[0];
                        score2 = Convert.ToInt32(shapeScore2Values[1]);

                        break;

                    case 3:

                        shape1trim = arg3Array[0].Trim();
                        ShapeScore1Values = shape1trim.Split(",");

                        shape2trim = arg3Array[1].Trim();
                        shapeScore2Values = shape2trim.Split(",");

                        string shape3trim = arg3Array[2].Trim();
                        shapeScore3Values = shape3trim.Split(",");

                        form1 = ShapeScore1Values[0];
                        score1 = Convert.ToInt32(ShapeScore1Values[1]);

                        form2 = shapeScore2Values[0];
                        score2 = Convert.ToInt32(shapeScore2Values[1]);

                        form3 = shapeScore3Values[0];
                        score3 = Convert.ToInt32(shapeScore3Values[1]);


                        break;
                    case 4:

                        shape1trim = arg3Array[0].Trim();
                        ShapeScore1Values = shape1trim.Split(",");

                        shape2trim = arg3Array[1].Trim();
                        shapeScore2Values = shape2trim.Split(",");

                        shape3trim = arg3Array[2].Trim();
                        shapeScore3Values = shape3trim.Split(",");

                        string shape4trim = arg3Array[3].Trim();
                        shapeScore4Values = shape4trim.Split(",");

                        form1 = ShapeScore1Values[0];
                        score1 = Convert.ToInt32(ShapeScore1Values[1]);

                        form2 = shapeScore2Values[0];
                        score2 = Convert.ToInt32(shapeScore2Values[1]);

                        form3 = shapeScore3Values[0];
                        score3 = Convert.ToInt32(shapeScore3Values[1]);

                        form4 = shapeScore4Values[0];
                        score4 = Convert.ToInt32(shapeScore4Values[1]);

                        break;

                }

            }
            
    }
}
