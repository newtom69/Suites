using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
