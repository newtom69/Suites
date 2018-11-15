using System;
using System.Linq;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(45);
            OrFibonacci(40);
            NombreOr(40);
            Pi(25);
            Heron(9,2);
            Syracuse(50,1978);
            Conway(16, 1);
            Factorielle(12);
            Bale(50);
            PiWallis(100000);
        }

        public static void OrFibonacci(int max)
        {
            AppelSuite(new OrFibonacci(), 0, max);
        }

        public static void NombreOr(int max)
        {
            AppelSuite(new NombreOr(), 0, max);
        }

        public static void Bale(int max)
        {
            AppelSuite(new Bale(), 0, max);
        }

        public static void PiWallis(int max)
        {
            AppelSuite(new PiWallis(), 0, max);
        }

        public static void Pi(int max)
        {
            AppelSuite(new Pi(), 0, max);
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
