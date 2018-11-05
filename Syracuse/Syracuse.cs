using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syracuse
{
    class Syracuse
    {
        public static IEnumerable<double> Suite(int nbDepart)
        {
            int courant = nbDepart;

            while (true)
            {
                if (courant % 2 == 0)
                    yield return courant = courant/2;
                else
                    yield return courant = courant*3 + 1;
            }
        }
    }
}
