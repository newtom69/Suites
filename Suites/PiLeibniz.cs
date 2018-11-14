using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    class PiLeibniz : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double suivant;
            double courant = 0;
            double qsuivant;
            int k = 0;
            while (true)
            {
                suivant = courant + (4 * Math.Pow(-1,k)) / (2 * k + 1);
                qsuivant = (suivant + courant) / 2;
                yield return qsuivant;
                courant = suivant;
                k++;
            }
        }
    }
}
