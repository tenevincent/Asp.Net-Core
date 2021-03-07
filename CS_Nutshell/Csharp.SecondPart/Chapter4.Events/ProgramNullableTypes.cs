using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Events
{
    class ProgramNullableTypes
    {
        static void Main(string[] args)
        {

            NullableTypesDemo();

            ImplicitAndExplicitNullableConversions();


            BoxingAndUnboxing();

            OperatorLifting();

            OperatorLiftingRelationalOperators();

        }

        private static void OperatorLiftingRelationalOperators()
        {
            // The relational operators work on the principle that it is meaningless to compare null operands:

            int? x = 5;
            int? y = null;
            {
                bool b = x < y;
                b.Dump();
            }

            // Translation:
            {
                bool b = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
                b.Dump();
            }
        }

        private static void OperatorLifting()
        {
            // Despite the Nullable<T> struct not defining operators such as <, >, or even ==, the 
            // following code compiles and executes correctly, thanks to operator lifting:

            int? x = 5;
            int? y = 10;
            {
                bool b = x < y;      // true
                b.Dump();
            }
            // The above line is equivalent to:
            {
                bool b = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
                b.Dump();
            }
        }

        private static void BoxingAndUnboxing()
        {
            object o = "string";
            int? x = o as int?;
            Console.WriteLine(x.HasValue);   // False
        }

        private static void ImplicitAndExplicitNullableConversions()
        {
            // The conversion from T to T? is implicit, and from T? to T is explicit:
            int? x = 5;        // implicit
            int y = (int)x;    // explicit

        }

        private static void NullableTypesDemo()
        {
            // To represent null in a value type, you must use a special construct called a nullable type:
            {
                int? i = null;                     // Nullable Type
                Console.WriteLine(i == null);     // True
            }
            // Equivalent to:
            {
                Nullable<int> i = new Nullable<int>();
                Console.WriteLine(!i.HasValue);           // True
            }
        }
    }
}
