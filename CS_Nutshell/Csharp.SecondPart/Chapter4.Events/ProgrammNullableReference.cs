using System;
using System.Collections.Generic;
using System.Text;

#nullable enable
#nullable enable annotations   // Enable just the nullable annotation context
// Now let's enable the warning context, too  
#nullable enable warnings




namespace Chapter4.Events
{
    class ProgrammNullableReference
    {
       static void Foo1(string? s) => Console.Write(s.Length);

        // which we can remove with the null-forgiving operator:
        void Foo2(string? s) => Console.Write(s!.Length);
        // If we add a check, we no longer need the null-forgiving operator in this case:
        void Foo3(string? s)
        {
            if (s != null) Console.Write(s.Length);
        }


        static void Main(string[] args)
        {

            string s1 = null;   // Generates a compiler warning!
            string? s2 = null;  // OK: s2 is nullable reference type



        }
    }

    class Foo
    {
        string x;     // Generates a warning
    }


}
