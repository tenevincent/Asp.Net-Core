using ConsoleDump;
using System;

namespace Chapter3.Section4.Enums
{
    class Program
    {
        // An enum is a special value type that lets you specify a group of named numeric constants:



        static void Main(string[] args)
        {
            // EnumsSimpleUsage();
            // EnumConvertion();

            DemoFlagEnums();

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        private static void DemoFlagEnums()
        {
            // You can combine enum members. To prevent ambiguities, members of a combinable enum require
            // explicitly assigned values, typically in powers of two:

            BorderSides leftRight = BorderSides.Left | BorderSides.Right;

            if ((leftRight & BorderSides.Left) != 0)
                Console.WriteLine("Includes Left");   // Includes Left

            string formatted = leftRight.ToString();   // "Left, Right"

            BorderSides s = BorderSides.Left;
            s |= BorderSides.Right;
            Console.WriteLine(s == leftRight);   // True

            s ^= BorderSides.Right;               // Toggles BorderSides.Right
            Console.WriteLine(s);                // Left
        }

        private static void EnumConvertion()
        {
            // You can convert an enum instance to and from its underlying integral value with an explicit cast:

            int i = (int)BorderSide.Left;
            i.Dump("i");

            BorderSide side = (BorderSide)i;
            side.Dump("side");

            bool leftOrRight = (int)side <= 2;
            leftOrRight.Dump("leftOrRight");

            HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;
            h.Dump("h");

            BorderSide b = 0;    // No cast required with the 0 literal.
            b.Dump("b");


        }


        //[Flags]
        public enum BorderSides { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }



        public enum BorderSide { Left, Right, Top, Bottom }

        public enum HorizontalAlignment
        {
            Left = BorderSide.Left,
            Right = BorderSide.Right,
            Center
        }



        private static void EnumsSimpleUsage()
        {
            BorderSide topSide = BorderSide.Top | BorderSide.Left;
            bool isTop = (topSide == BorderSide.Top);
            isTop.Dump();
        }
    }




    public enum BorderSide { Left, Right, Top, Bottom }

    // You may specify an alternative integral type:
    public enum BorderSideByte : byte { Left, Right, Top, Bottom }

    // You may also specify an explicit underlying value for each enum member:
    public enum BorderSideExplicit : byte { Left = 1, Right = 2, Top = 10, Bottom = 11 }

    public enum BorderSidePartiallyExplicit : byte { Left = 1, Right, Top = 10, Bottom }



}
