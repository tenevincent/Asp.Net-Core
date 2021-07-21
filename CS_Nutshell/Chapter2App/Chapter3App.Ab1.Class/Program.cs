using ConsoleDump;
using System;

namespace Chapter3App.Ab1.Class
{
    class Program
    {
        static void Main(string[] args)
        {

            // To call the deconstructor, we use the following special syntax:
            var rect = new Rectangle(3, 4);
            (float width, float height) = rect;          // Deconstruction
            Console.WriteLine(width + " " + height);    // 3 4

            // We can also use implicit typing:  
            var (x, y) = rect;          // Deconstruction
            Console.WriteLine(x + " " + y);

            // If the variables already exist, we can do a *deconstructing assignment*:
            (x, y) = rect;
            Console.WriteLine(x + " " + y);

            Octopus o = new();
            o.Age.Dump();

            Foo(123);      // int
            Foo(123.0);    // double
            Foo(123, 123F);  // int, float
            Foo(123F, 123);  // float, int


            Console.Read();
        }


        // We can overload Foo as follows:

      static  void Foo(int x) { "int".Dump(); }
        static void Foo(double x) { "double".Dump(); }
        static void Foo(int x, float y) { "int, float".Dump(); }
        static void Foo(float x, int y) { "float, int".Dump(); }



    }
}
