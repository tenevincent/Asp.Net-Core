using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 12 * 30;              //     Statement 1
            //Console.WriteLine(x);        //     Statement 2

            Console.WriteLine(FeetToInches(30));      // 360
            Console.WriteLine(FeetToInches(100));     // 1200

            Point? p = null;    // This line will not compile.
            int? x = null;    // Illegal, too.

            Console.WriteLine(p.HasValue);
            Console.WriteLine(x.HasValue);

            Console.ReadKey();
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }

    }


    // A value type cannot ordinarily have a null value:

    public struct Point { public int X, Y; }
    
    
    public class Panda
    {
        public string Name;             // Instance field
        public static int Population;   // Static field

        public Panda(string n)         // Constructor
        {
            Name = n;                      // Assign the instance field
            Population = Population + 1;   // Increment the static Population field
        }
    }

}
