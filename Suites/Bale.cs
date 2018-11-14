using System;
using System.Collections.Generic;

namespace Suites
{
    class Bale : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double courant = 0;
            double suivant;
            double n = 1;
            while (true)
            {
                suivant = courant + 1 / (n * n);
                yield return courant;
                courant = suivant;
                n++;

            }
        }
    }
}
