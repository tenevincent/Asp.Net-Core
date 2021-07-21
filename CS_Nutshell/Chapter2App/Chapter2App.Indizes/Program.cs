using ConsoleDump;
using System;

namespace Chapter2App.Indizes
{
    class Program
    {
        // You can return a ref local from a method. This is called a ref return:
        static string X = "Old Value";
        static ref string GetX() => ref X;    // This method returns a ref


        static void Main(string[] args)
        {

            Console.WriteLine(default(decimal).Dump()); // 0
            Console.WriteLine(default(Program).Dump()); // null



                                                 // You can optionally omit the type when it can be



            ref string xRef = ref GetX();       // Assign result to a ref local
            xRef = "New Value";
            Console.WriteLine(X);              // New Value



            // Indizes();

            //  RangesDemo();

            // NullOperatorDemo();

         //   RefsLocal();

            OutParameters();

            int total = Sum(1, 2, 3, 4,5,6,7);
            Console.WriteLine(total); // 10
                                      // The call to Sum above is equivalent to:
            int total2 = Sum(new int[] { 1, 2, 3, 4 });


            {
                string _;
                Split("Stevie Ray Vaughan", out string a, out _);
                Console.WriteLine(_); // Vaughan
            }

            {
                Split("Stevie Ray Vaughan", out string a, out _); // Discard 2nd param
                Console.WriteLine(a);
            }


            Console.Read();
        }


        private static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }


        private static void OutParameters()
        {
            // From C# 7, you can declare variables on the fly when calling methods with out parameters.

            Split("Stevie Ray Vaughan", out string a, out string b);
            Console.WriteLine(a);                      // Stevie Ray
            Console.WriteLine(b);                      // Vaughan

            Split("Stevie Ray Vaughan", out string x, out _);   // Discard the 2nd param
            Console.WriteLine(x);
        }

       private static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i]; // Increase sum by ints[i]
            return sum;
        }


        private static void RefsLocal()
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
        }

        private static void NullOperatorDemo()
        {
            {
                string s1 = null;
                string s2 = s1 ?? "nothing";   // s2 evaluates to "nothing"
                s2.Dump();
            }

            {
                string s1 = null;
                s1 ??= "something";
                Console.WriteLine(s1);  // something

                s1 ??= "everything";
                Console.WriteLine(s1);  // something
            }

            {
                System.Text.StringBuilder sb = null;
                string s = sb?.ToString();   // No error; s instead evaluates to null
                s.Dump();

                string s2 = sb?.ToString().ToUpper();   // s evaluates to null without error
                s2.Dump();
            }


            {
                // You can add the checked keyword to force overflow checking:

                int a = 1000000;
                int b = 1000000;

                int cc = a * b;

                // The following code throws OverflowExceptions:
                int c = checked(a * b);      // Checks just the expression.

                // Checks all expressions in statement block:
                checked
                {
                    int c2 = a * b;
                    c2.Dump();
                }
            }



        }

        private static void RangesDemo()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char[] firstTwo = vowels[..2].Dump();     // 'a', 'e'
            char[] lastThree = vowels[2..].Dump();    // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3].Dump();   // 'i'

            char[] lastTwo = vowels[^2..].Dump();     // 'o', 'u'

            Range firstTwoRange = 0..2;
            char[] firstTwo2 = vowels[firstTwoRange].Dump();   // 'a', 'e'
        }

        private static void Indizes()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1].Dump();   // 'u'
            char secondToLast = vowels[^2].Dump();   // 'o'

            Index first = 0;
            Index last = ^1;
            char firstElement = vowels[first].Dump();   // 'a'
            char lastElement2 = vowels[last].Dump();    // 'u'
        }
    }
}
