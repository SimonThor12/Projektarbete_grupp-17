using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    public interface IHandler<T>
    {
        public List<T> HandleInput();
    }
}
