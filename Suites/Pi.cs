using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    class Pi : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double pcourant = 3;
            double qcourant = 2 * Math.Sqrt(3);
            double psuivant;
            double qsuivant;
            while (true)
            {
                qsuivant = (2 * pcourant * qcourant) / (pcourant + qcourant);
                psuivant = Math.Sqrt(pcourant * qsuivant);
                yield return qcourant;
                qcourant = qsuivant;
                pcourant = psuivant;
            }
        }
    }
}

