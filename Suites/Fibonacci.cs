using System;
using System.Collections.Generic;

namespace Suites
{
    class Fibonacci : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            int courant = 1;
            int suivant = 1;
            while (true)
            {
                suivant = courant + (courant = suivant);
                yield return courant;
            }
        }

    }
}
