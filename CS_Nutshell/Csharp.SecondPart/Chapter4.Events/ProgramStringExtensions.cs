using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Events
{
    class ProgramStringExtensions
    {
        static void Main(string[] args)
        {
            // Extension methods allow an existing type to be extended with new methods without altering
            // the definition of the original type:

            Console.WriteLine("Perth".IsCapitalized());
            // Equivalent to:
           // Console.WriteLine(StringHelper.IsCapitalized("Perth"));

            // Interfaces can be extended, too:
            Console.WriteLine("Seattle".First());   // S


            string x = "sausage".Pluralize().Capitalize();
            x.Dump();

            // Equivalent to:
            string y = StringHelper.Capitalize(StringHelper.Pluralize("sausage"));
            y.Dump();

            // LINQPad's Dump method is an extension method:
            "sausage".Pluralize().Capitalize().Dump();


            // Any compatible instance method will always take precedence over an extension method:
            new Test().Foo("string");  // Instance method wins, as you'd expect
            new Test().Foo(123);       // Instance method still wins

            // The extension method with more specific arguments wins. Classes & structs are
            // considered more specific than interfaces:
            "Perth".IsCapitalized().Dump();


        }



    }

    static class EnumerableHelper
    {
        public static bool IsCapitalized(this IEnumerable<char> s)
        {
            "Enumerable.IsCapitalized".Dump();
            return char.IsUpper(s.First());
        }
    }

    public class Test
    {
        public void Foo(object x) { "Instance".Dump(); }    // This method always wins
    }


}
