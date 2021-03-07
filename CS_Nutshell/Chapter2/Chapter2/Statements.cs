using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Statements
    {
        static void Main(string[] args)
        {

            TellMeTheType(12);
            TellMeTheType("hello");
            TellMeTheType(true);
            var anyObject = new { Name = "Tene" };
            TellMeTheType(anyObject);

            object x = anyObject;
            switch (x)
            {
                case bool b when b == true:     // Fires only when b is true
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
                default:
                    Console.WriteLine("The value is not a boolean");
                    break;
            }

            object xdata = 3000F;

            switch (xdata)
            {
                case float f when f > 1000:
                    Console.WriteLine("The value is a float");
                    break;
                case double d when d > 1000:
                    Console.WriteLine("The value is double");
                    break;
                case decimal m when m > 1000:
                    Console.WriteLine("We can refer to x here but not f or d or m");
                    break;
            }



        }



        static void TellMeTheType(object x)   // object allows any type.
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("It's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }



    }
}
