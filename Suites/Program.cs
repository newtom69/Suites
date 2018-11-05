using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Fibonacci");
                int max = 45;
                int i = 0;
                foreach (var nb in Fibonacci.Suite().Take(max))
                {
                    Console.WriteLine($"entier {++i} : {nb}");
                }
                Console.ReadLine();
            }
            {
                Console.WriteLine("Syracuse");
                int nombreInitial = 1978;
                int max = 50;
                int i = 0;
                foreach (var nb in Syracuse.Suite(nombreInitial).Take(max))
                {
                    Console.WriteLine($"entier {++i} : {nb}");
                }

                Console.ReadLine();
            }
            {
                Console.WriteLine("Conway");
                int i = 0;
                foreach (var nb in Conway.Suite("1").Take(16))
                {
                    Console.WriteLine($"suite {++i} : {nb}");
                }

                Console.ReadLine();
            }

        }
    }
}
