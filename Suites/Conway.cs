using System;
using System.Collections.Generic;

namespace Suites
{
    class Conway : Suite
    {
        override public IEnumerable<Object> LaSuite(int depart)
        {
            int indexChaineDepart1 = 0;
            int indexChaineDepart2 = 0;
            int nbChiffreCourant = 0;
            int chiffreCourant = 0;
            string chaine;
            string chaineDepart = depart.ToString();
            string chaineCourant = chaineDepart;

            yield return chaineDepart;
            while (true)
            {
                indexChaineDepart1 = 0;
                indexChaineDepart2 = 0;
                chaine = chaineCourant;
                chaineCourant = "";
                while (indexChaineDepart1 < chaine.Length)
                {
                    while (indexChaineDepart2 < chaine.Length && chaine[indexChaineDepart1] == chaine[indexChaineDepart2])
                    {
                        nbChiffreCourant++;
                        indexChaineDepart2++;
                    }
                    chiffreCourant = Int32.Parse(chaine[indexChaineDepart1].ToString());
                    indexChaineDepart1 = indexChaineDepart2;
                    chaineCourant += nbChiffreCourant;
                    chaineCourant += chiffreCourant;
                    nbChiffreCourant = 0;
                }
                yield return chaineCourant;
            }
        }
    }
}
