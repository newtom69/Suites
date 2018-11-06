using System;
using System.Linq;
using System.Xml.Schema;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            //AppelFibonacci(45);
            //AppelSyracuse(50, 1978);
            //AppelConway(16, 1);
            AppelFactorielle(20);
        }


        static void AppelFibonacci(int max)
        {
            Console.WriteLine("Fibonacci");
            int i = 0;
            foreach (var nb in Fibonacci.Suite().Take(max))
                Console.WriteLine($"Fibonacci {++i} : {nb}");

            Console.ReadLine();
        }

        static void AppelSyracuse(int max, int nombreInitial)
        {
            Console.WriteLine("Syracuse");
            int i = 0;
            foreach (var nb in Syracuse.Suite(nombreInitial).Take(max))
                Console.WriteLine($"Syracuse {++i} : {nb}");

            Console.ReadLine();
        }

        static void AppelConway(int max, int nombreInitial)
        {
            Console.WriteLine("Conway");
            int i = 0;
            foreach (var nb in Conway.Suite(nombreInitial).Take(max))
                Console.WriteLine($"Conway {++i} : {nb}");
            
            Console.ReadLine();
        }

        static void AppelFactorielle(int max)
        {
            Console.WriteLine("Factorielle");
            int i = 0;
            foreach (var nb in Factorielle.Suite().Take(max))
                Console.WriteLine($"Factorielle {++i} : {nb}");

            Console.ReadLine();
        }
    }
}
