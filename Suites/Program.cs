using System;
using System.Linq;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            Heron(9,2);
            Fibonacci(45);
            Syracuse(50,1978);
            Conway(16, 1);
            Factorielle(12);
        }

        public static void Heron(int max, int nbInitial)
        {
            AppelSuite(new Heron(), nbInitial, max);
        }

        public static void Syracuse(int max, int nbInitial)
        {
            AppelSuite(new Syracuse(), nbInitial, max);
        }

        public static void Conway(int max, int nbInitial)
        {
            AppelSuite(new Conway(), nbInitial, max);
        }

        public static void Fibonacci(int max)
        {
            AppelSuite(new Fibonacci(), 0, max);
        }

        public static void Factorielle(int max)
        {
            AppelSuite(new Factorielle(), 0, max);
        }

        public static void AppelSuite(Suite laSuite, int init, int max)
        {
            Console.WriteLine(laSuite.ToString().Substring(7));
            int i = 0;
            foreach (var nb in laSuite.LaSuite(init).Take(max))
                Console.WriteLine($"{laSuite.ToString().Substring(7)} {++i} : {nb}");
            Console.ReadLine();
        }
    }
}
