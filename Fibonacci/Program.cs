using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 45;
            int i = 0;
            foreach (var nb in Fibonacci().Take(max))
            {
                Console.WriteLine($"entier {++i} : {nb}");
            }
        }

        public static IEnumerable<double> Fibonacci()
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
