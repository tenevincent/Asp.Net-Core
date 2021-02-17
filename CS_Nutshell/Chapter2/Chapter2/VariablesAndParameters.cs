using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class VariablesAndParameters
    {

        static void Main(string[] args)
        {

            {
                int x = 8;
                Foo(ref x);            // Ask Foo to deal directly with x
                Console.WriteLine(x);   // x is now 9
            }


            {
                string x = "Penn";
                string y = "Teller";
                Swap(ref x, ref y);
                Console.WriteLine(x);   // Teller
                Console.WriteLine(y);   // Penn
            }

            {
                Split("Stevie Ray Vaughan", out string a, out string b);
                Console.WriteLine(a);                      // Stevie Ray
                Console.WriteLine(b);                      // Vaughan

            }

            {
                var result = Split("Stevie Ray Vaughan");
                Console.WriteLine(result.FirstName);                      // Stevie Ray
                Console.WriteLine(result.LastName);                      // Vaughan
            }


            int total = Sum(1, 2, 3, 4, 5, 6, 6, 7);
            Console.WriteLine(total);

            {
                // C# 7 added an esoteric feature, whereby you can define a local variable that references
                // an element in an array or field in an object. 
                int[] numbers = { 0, 1, 2, 3, 4 };
                ref int numRef = ref numbers[2];

                // In this example, numRef is a reference to the numbers [2].When we modify numRef,
                // we modify the array element:
                numRef *= 10;
                Console.WriteLine(numRef);        // 20
                Console.WriteLine(numbers[2]);   // 20


                var numberStore = new NumberStore();
                ref int number = ref numberStore.FindNumber(5);
                number *= 5;
                Console.WriteLine(number);

            }
            Console.ReadKey();
        }


        class NumberStore
        {
          private  int[] numbers = { 1, 2, 3, 4, 5, 6, 127, 255, 511, 1023 };

            public ref int FindNumber(int target)
            {
                for (int ctr = 0; ctr < numbers.Length; ctr++)
                {
                    if (numbers[ctr] >= target)
                        return ref numbers[ctr];
                }
                return ref numbers[0];
            }

            public override string ToString() => string.Join(" ", numbers);
        }



        // The params parameter modifier on the last parameter of a method accepts any number of parameters
        // of a specified type:

        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i];                       // Increase sum by ints[i]
            return sum;
        }



        static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        static (string FirstName, string LastName) Split(string name)
        {
            int i = name.LastIndexOf(' ');
            var firstName = name.Substring(0, i);
            var lastName = name.Substring(i + 1);
            return (firstName, lastName);
        }




        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }



        static void Foo(ref int p)
        {
            p = p + 1;               // Increment p by 1
            Console.WriteLine(p);   // Write p to screen
        }


    }
}
