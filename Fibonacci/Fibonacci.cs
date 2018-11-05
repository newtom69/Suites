using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        public static IEnumerable<double> Suite()
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
