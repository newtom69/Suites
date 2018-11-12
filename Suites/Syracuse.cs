using System;
using System.Collections.Generic;

namespace Suites
{
    class Syracuse : Suite
    {
        override public IEnumerable<Object> LaSuite(int nbDepart)
        {
            int courant = nbDepart;
            while (true)
            {
                if (courant % 2 == 0)
                    yield return courant = courant / 2;
                else
                    yield return courant = courant * 3 + 1;
            }
        }
    }
}
