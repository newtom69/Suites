using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    // suite de Héron : calcul approché de racine carré de "nombre"
    class Heron : Suite
    {
        override public IEnumerable<Object> LaSuite(int nombre)
        {
            double courant = nombre;
            double suivant;
            while (true)
            {
                suivant = (courant + nombre / (courant) )/2;
                yield return courant;
                courant = suivant;
            }
        }
    }
}
