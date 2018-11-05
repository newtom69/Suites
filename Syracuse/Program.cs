using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syracuse
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreInitial = 13111978;
            int max = 220;
            int i = 0;
            foreach (var nb in Syracuse.Suite(nombreInitial).Take(max))
            {
                Console.WriteLine($"entier {++i} : {nb}");
            }
            Console.ReadLine();
        }
    }
}
