using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleAllInput

    {
        public IHandler<Punkt> punktLista { get; private set; }
        public IHandler<Form> formLista { get; private set; }
        public HandleInput3 shapeScore { get; private set; }
        public HandleAllInput(IHandler<Punkt> punktLista, IHandler<Form> formLista, HandleInput3 shapeScore)
        {
            this.punktLista = punktLista;
            this.formLista = formLista;
            this.shapeScore = shapeScore;
        }
    }
}
