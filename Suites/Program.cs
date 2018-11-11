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
            Program prg = new Program();
            prg.Fibonacci(45);
            prg.Syracuse(50,1978);
            prg.Conway(16, 1);
            prg.Factorielle(12);
        }

        public void Syracuse(int max, int nbInitial)
        {
            Appel(MethodBase.GetCurrentMethod().Name, nbInitial, max);
        }

        public void Conway(int max, int nbInitial)
        {
            Appel(MethodBase.GetCurrentMethod().Name, nbInitial, max);
        }

        public void Fibonacci(int max)
        {
            Appel(MethodBase.GetCurrentMethod().Name, 0, max);
        }

        public void Factorielle(int max)
        {
            Appel(MethodBase.GetCurrentMethod().Name, 0, max);
        }


        public void Appel(string methode, int nombreInitial, int max)
        {
            Console.WriteLine(methode);
            object[] args = new object[1];
            args[0]= nombreInitial;
            Suite laSuite = new Suite();
            IEnumerable<Object> elementsDeLaSuite = (IEnumerable<Object>)laSuite.GetType().InvokeMember(methode,
                BindingFlags.Public | BindingFlags.Instance ,
                null, laSuite, args);

            int i = 0;
            foreach (var nb in elementsDeLaSuite.Take(max))
                Console.WriteLine($"{methode} {++i} : {nb}");

            Console.ReadLine();
        }
    }
}
