using ConsoleDump;
using System;
using System.Collections.Generic;

namespace Chapter4.AnonymTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          //  SimpleAnonymType();

          //  AnonymTypeOmittingIdentifiers();

            AnonymTypesIdentity();


            Console.WriteLine("Hello World!");
        }

        private static void AnonymTypesIdentity()
        {
            // Two anonymous type instances will have the same underlying type if their elements are 
            // same-typed and they’re declared within the same assembly

            var a1 = new { X = 2, Y = 4 };
            var a2 = new { X = 2, Y = 4 };
            Console.WriteLine(a1.GetType() == a2.GetType());   // True

            // Additionally, the Equals method is overridden to perform equality comparisons:

            Console.WriteLine(a1 == a2);         // False
            Console.WriteLine(a1.Equals(a2));   // True
        }

        private static void AnonymTypeOmittingIdentifiers()
        {
            int Age = 23;
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);

            // The following:
            {
                var dude = new { Name = "Bob", list.Count, Age, Age.ToString().Length };
                dude.Dump();
            }
            // is shorthand for:
            {
                var dude = new { Name = "Bob", Age = Age, Length = Age.ToString().Length };
                dude.Dump();
            }
        }

        private static void SimpleAnonymType()
        {
            // An anonymous type is a simple class created by the compiler on the fly to store a set of values
            var dude = new { Name = "Bob", Age = 23 };
            dude.Dump();
            // The ToString() method is overloaded:
            dude.ToString().Dump();
        }
    }
}
