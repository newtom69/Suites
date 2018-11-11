using System;
using System.Collections.Generic;

namespace Suites
{
    class Suite
    {
        public IEnumerable<Object> Syracuse(int nbDepart)
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

        public IEnumerable<Object> Fibonacci(int inutile)
        {
            int courant = 1;
            int suivant = 1;
            while (true)
            {
                suivant = courant + (courant = suivant);
                yield return courant;
            }
        }

        public IEnumerable<Object> Factorielle(int inutile)
        {
            int courant = 1;
            int suivant = 1;
            while (true)
            {
                suivant *= courant++;
                yield return suivant;
            }
        }
        public IEnumerable<string> Conway(int depart)
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
