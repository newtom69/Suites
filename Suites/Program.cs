using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(45);
            Syracuse(50,1978);
            Conway(16, 1);
            Factorielle(12);
        }

        public static void Syracuse(int max, int nbInitial)
        {
            Appel(MethodBase.GetCurrentMethod().Name, nbInitial, max);
        }

        public static void Conway(int max, int nbInitial)
        {
            Appel(MethodBase.GetCurrentMethod().Name, nbInitial, max);
        }

        public static void Fibonacci(int max)
        {
            Appel(MethodBase.GetCurrentMethod().Name, 0, max);
        }

        public static void Factorielle(int max)
        {
            Appel(MethodBase.GetCurrentMethod().Name, 0, max);
        }


        public static void Appel(string methode, int nombreInitial, int max)
        {
            Console.WriteLine(methode);
            object[] args = new object[1];
            args[0]= nombreInitial;
            Suite laSuite = new Suite();
            IEnumerable<Object> elementsDeLaSuite = 
                (IEnumerable<Object>)laSuite.GetType().InvokeMember(methode,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, laSuite, args);

            int i = 0;
            foreach (var nb in elementsDeLaSuite.Take(max))
                Console.WriteLine($"{methode} {++i} : {nb}");

            Console.ReadLine();
        }
    }
}
