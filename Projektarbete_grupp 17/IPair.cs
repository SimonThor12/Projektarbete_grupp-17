using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    interface IPair<X,Y> 
    {
        public Y y { get; set; }
        public X x { get; set; }


    }
}
