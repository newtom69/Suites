using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    class OrFibonacci : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double courant = 1;
            double suivant = 1;
            while (true)
            {
                suivant = courant + (courant = suivant);
                yield return suivant/courant;
            }
        }
    }
}
