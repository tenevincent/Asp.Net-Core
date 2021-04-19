using ConsoleDump;
using System;

namespace Chapter4.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // PropertyPattern();

            VarPatternDemo();

            // Constant pattern
            // Foo(3);

         //   RelationalPatternDemo();

            RelationalPatternWithObjectType();

            Console.ReadKey();
        }

        private static void RelationalPatternWithObjectType()
        {
            object obj = 2m;                  // decimal
            Console.WriteLine(obj is < 3m);  // True
            Console.WriteLine(obj is < 3);   // False
        }

        private static void RelationalPatternDemo()
        {
            int x = 150;
            if (x is > 100) Console.WriteLine("x is greater than 100");

            GetWeightCategory(15).Dump();
            GetWeightCategory(20).Dump();
            GetWeightCategory(25).Dump();
             
        }


       static string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };


        static void Foo(object obj)
        {
            // C# won’t let you use the == operator, because obj is object.
            // However, we can use ‘is’
            if (obj is 3) Console.WriteLine("three");
        }


        private static void PropertyPattern()
        {
            string obj = "data";
            if (obj is string { Length: 4 })
                Console.WriteLine("Hello World!");

            var uri = new Uri("http://www.google.com");
            Console.WriteLine(ShouldAllow(uri));
        }



        private static void VarPatternDemo()
        {
            IsJanetOrJohn("Janet").Dump();
            IsJanetOrJohn("john").Dump();

        }

        static
            bool IsJanetOrJohn(string name) =>
              name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");

        static bool ShouldAllow(Uri uri) => uri switch
   {
       { Scheme: "http", Port: 80, Host: var host } => host.Length < 1000,
       { Scheme: "https", Port: 443 } => true,
       { Scheme: "ftp", Port: 21 } => true,
       { IsLoopback: true } => true,
       _ => false
        };


    }
}
