using System;

namespace Chapter3.Section1.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var octopus = new Octopus();
            octopus.Age.Dump();
            octopus.Print();


            Console.ReadKey();

        }
    }


    class Octopus
    {
        private string name, vorname;
        public int Age = 3, CountryCode = 10;
        static readonly int legs = 8, eyes = 1;

        public const string Message = "Hello World";

        int Foo1(int x) { return x * 2; }

        int Foo2(int x) => x * 2;

        // Overloading
        void Foo(int x) { "int".Dump(); }

        void Foo(double x) { "double".Dump(); }

        void Foo(int x, float y) { "int, float".Dump(); }

        void Foo(float x, int y) { "float, int".Dump(); }

        int Hoo(ref int x) =>  x;     // OK so far
        

        public void Print()
        {
            Console.WriteLine($"{this.name} {this.vorname}, {this.Age}");
        }
    }

}
