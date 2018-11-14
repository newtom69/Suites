using System;
using System.Collections.Generic;

namespace Suites
{
    class NombreOr : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double courant = 2;
            double suivant;
            while (true)
            {
                suivant = 1 + 1/courant;
                yield return courant;
                courant = suivant;
            }
        }
    }
}
