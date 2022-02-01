using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HämtalTotalPoäng
    {
        
      private HandleAllInput allInput;

        public HämtalTotalPoäng (HandleAllInput AllInput)
        {
            allInput = AllInput;
           
        }

        public double KalkTotalPoäng()
        {
            
            double totalPoäng = 0;

            for (int i = 0; i < allInput.punktLista.Count; i++)
            {
                
                for (int j = 0; j < allInput.formLista.Count; j++)
                {
                    allInput.shapeScoreLista.TryGetValue(allInput.formLista[j].formtyp, out int value);
                    if (allInput.formLista[j].IsInside(allInput.punktLista[i].koordinat))
                    {
                        totalPoäng += allInput.formLista[j].GetArea() + allInput.punktLista[i].pointScore + value;//allInput.GetShapeScore(allInput.formLista[j]);
                    }
                    else if (!allInput.formLista[j].IsInside(allInput.punktLista[i].koordinat))
                    {
                        
                        totalPoäng += ((allInput.formLista[j].GetArea() + value) / 4);//allInput.GetShapeScore(allInput.formLista[j])) / 4;
                    }

                }
                
            }
            return totalPoäng;


        }

    }
}
