using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Events
{
    class ProgramEnumerationAndIterators
    {
        static void Main(string[] args)
        {
            // Enumerations();

            //  DictionariesInitialize();

            var list = Fibs(16).ToList();
            foreach (int fib in list)
                Console.Write(fib + "  ");


            foreach (string s in Foo(true))
                Console.WriteLine(s);


        }


        static IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";

            if (breakEarly)
               yield  break;

            yield return "Three";
        }




        static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }




        private static void DictionariesInitialize()
        {
            var dict1 = new Dictionary<int, string>()
            {
                { 5, "five" },
                { 10, "ten" }
            };

            dict1.Dump();

            var dict2 = new Dictionary<int, string>()
            {
                [3] = "three",
                [10] = "ten"
            };

            dict2.Dump();
        }

        private static void Enumerations()
        {
            // High-level way of iterating through the characters in the word “beer”:

            foreach (char c in "beer")
                Console.WriteLine(c);

            // Low-level way of iterating through the same characters:
            using (var enumerator = "beer".GetEnumerator())
                while (enumerator.MoveNext())
                {
                    var element = enumerator.Current;
                    Console.WriteLine(element);
                }
        }
    }
}
