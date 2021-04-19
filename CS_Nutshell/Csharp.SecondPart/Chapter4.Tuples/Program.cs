using ConsoleDump;
using System;
using System.Linq;

namespace Chapter4.Tuples
{
    class Program
    {
        static (string Name, int Age) GetPerson() => ("Bob", 23);



        static void Main(string[] args)
        {

            // TuplesLiteralDemo();

            // TupleSpecifyingType();

            // ReturningTupleFromMethod();

            // NamingTupleElements();

            // TupleCompatibilty();

            //  CreatingTuple();

            //  DeconstructingTuples();

            TuplesComparaison();

        }

        private static void TuplesComparaison()
        {
            var t1 = ("one", 1);
            var t2 = ("one", 1);
            Console.WriteLine(t1.Equals(t2));    // True
            var tuples = new[]
            {
                ("B", 50),
                ("B", 10),
                 ("C", 1),
                  ("D", 3),
  ("A", 30),
  ("A", 20)
};

            tuples.OrderBy(x => x.Item2).Dump("They're all now in order!");



        }

        private static void DeconstructingTuples()
        {
            {
                var bob = ("Bob", 23);
                (string name, int age) = bob;   // Deconstruct the bob tuple into
                                                // separate variables (name and age).
                Console.WriteLine(name);
                Console.WriteLine(age);
            }

            {
                var (name, age, sex) = GetBob();
                Console.WriteLine(name);        // Bob
                Console.WriteLine(age);         // 23
                Console.WriteLine(sex);         // M
            }


        }

        static (string Name, int Age, char Sex) GetBob() => ("Bob", 23, 'M');



        private static void CreatingTuple()
        {
            ValueTuple<string, int> bob1 = ValueTuple.Create("Bob", 23);
            (string Name, int Age) bob2 = ValueTuple.Create("Bob", 23);

            bob2.Item1.Dump();


            bob1.Dump();
            bob2.Dump();
        }

        private static void TupleCompatibilty()
        {
            (string Name, int Age, char Sex) bob1 = ("Bob", 23, 'M');
            (string Age, int Sex, char Name) bob2 = bob1;   // No error!

            // Our particular example leads to confusing results:
            Console.WriteLine(bob2.Name);    // M
            Console.WriteLine(bob2.Age);     // Bob
            Console.WriteLine(bob2.Sex);     // 23
        }

        private static void NamingTupleElements()
        {
            var tuple = (Name: "Bob", Age: 23);

            Console.WriteLine(tuple.Name);     // Bob
            Console.WriteLine(tuple.Age);      // 23
        }

        private static void ReturningTupleFromMethod()
        {
            var  person = GetPerson();   // Could use 'var' here if we want
            Console.WriteLine(person.Name);    // Bob
            Console.WriteLine(person.Age);    // 23
        }

        private static void TupleSpecifyingType()
        {
            (string Name, int Age) bob = ("Bob", 23);   // var is not compulsory with tuples!

            bob.Name.Dump();
            bob.Age.Dump();


            bob.Item1.Dump();
            bob.Item2.Dump();
        }

        private static void TuplesLiteralDemo()
        {
            var bob = ("Bob", 23);    // Allow compiler to infer the element types

             bob.Item1.Dump() ;   // Bob
             bob.Item2.Dump() ;   // 23

            // Tuples are mutable value types:

            var joe = bob;                 // joe is a *copy* of job
            joe.Item1 = "Joe";             // Change joe’s Item1 from Bob to Joe
            bob.Dump();       // (Bob, 23)
            joe.Dump();       // (Joe, 23)
        }
    }
}
