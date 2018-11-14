using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    class PiWallis : Suite
    {
        override public IEnumerable<Object> LaSuite(int inutile)
        {
            double suivant;
            double courant = 1;
            double k = 1;
            while (true)
            {
                suivant = courant * 2*k / (2*k - 1) * 2*k / (2*k + 1);
                yield return 2*suivant;
                courant = suivant;
                k++;
            }
        }
    }
}
