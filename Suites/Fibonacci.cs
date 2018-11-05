using System.Collections.Generic;

namespace Suites
{
    class Fibonacci
    {
        public static IEnumerable<int> Suite()
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
