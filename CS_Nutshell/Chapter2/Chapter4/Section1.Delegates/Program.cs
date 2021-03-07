using System;

namespace Section1.Delegates
{
    // A delegate type declaration is like an abstract method declaration, prefixed with the delegate keyword:
    delegate int Transformer(int x);
    delegate void SomeDelegate();


    class Program
    { 
        static void Main(string[] args)
        { 
            // To create a delegate instance, assign a method to a delegate variable:  
            Transformer t = new Custom().Square;          // Create delegate instance
            int result = t.Invoke(3);               // Invoke delegate
            Console.WriteLine($"{result} # {t.Method} # {t.Target}");      // 9
             

            AssignMethodDynamically();

            DelegatesMultiCasting();



            Console.WriteLine("Hello World!");
        }

        private static void DelegatesMultiCasting()
        {
            SomeDelegate d = SomeMethod1;
            d += SomeMethod2;

            d();
            " -- SomeMethod1 and SomeMethod2 both fired\r\n".Dump();
            d -= SomeMethod1;
            d();
            " -- Only SomeMethod2 fired".Dump();
        }

        private static void AssignMethodDynamically()
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square);      // Hook in the Square method
            values.Dump();

            values = new int[] { 1, 2, 3 };
            Util.Transform(values, Cube);        // Hook in the Cube method
            values.Dump();

        }

        static void SomeMethod1() { "SomeMethod1".Dump(); }
        static void SomeMethod2() { "SomeMethod2".Dump(); }


        static int Square(int x) => x * x;
        static int Cube(int x) => x * x * x;

    }


    class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }


    class Custom
    {
        public int Square(int x) => x * x;
    }
}
