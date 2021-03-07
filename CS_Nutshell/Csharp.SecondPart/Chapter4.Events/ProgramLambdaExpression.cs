using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Events
{
    public class ProgramLambdaExpression
    {
        static void Main(string[] args)
        {
           // LambdaExpressionSimple();

           // CapturingOuterVariables();

            CapturingIterationVariables();

        }

        private static void CapturingIterationVariables()
        {
            // When you capture the iteration variable in a for-loop, C# treats that variable as though it was
            // declared outside the loop. This means that the same variable is captured in each iteration:
            {
                Action<int>[] actions = new Action<int>[3];

                for (int i = 0; i < 3; i++)
                    actions[i] = (x) => Console.WriteLine(i + $"_{x}");

                foreach (var a in actions) a(1);     // 333 (instead of 123)
            }

            // Each closure captures the same variable, i. When the delegates are later invoked, each delegate
            // sees its value at time of invocation - which is 3. We can illustrate this better by expanding
            // the for loop as follows:
            {
                Action[] actions = new Action[3];
                int i = 0;
                actions[0] = () => Console.Write(i);
                i = 1;
                actions[1] = () => Console.Write(i);
                i = 2;
                actions[2] = () => Console.Write(i);
                i = 3;
                foreach (Action a in actions) a();    // 333
            }
        }

        private static void CapturingOuterVariables()
        {
            // A lambda expression can reference the local variables and parameters of the method
            // in which it’s defined (outer variables)

            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));           // 6

            // Captured variables are evaluated when the delegate is invoked, not when the variables were captured:
            factor = 10;
            Console.WriteLine(multiplier(3));           // 30

            // Lambda expressions can themselves update captured variables:
            int seed = 0;
            Func<int> natural = () => seed++;
            Console.WriteLine(natural());           // 0
            Console.WriteLine(natural());           // 1
            Console.WriteLine(seed);                // 2
        }

        private static void LambdaExpressionSimple()
        {
            // A lambda expression is an unnamed method written in place of a delegate instance.
            // A lambda expression has the following form:
            //   (parameters) => expression-or-statement-block

            Transformer sqr = x => x * x;
            Console.WriteLine(sqr(3));    // 9

            // Using a statement block instead:
            Transformer sqrBlock = x => { return x * x; };
            Console.WriteLine(sqr(3));

            // Using a generic System.Func delegate:
            Func<int, int> sqrFunc = x => x * x;
            Console.WriteLine(sqrFunc(3));

            // Using multiple arguments:
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            int total = totalLength("hello", "world");
            total.Dump("total");


            // Explicitly specifying parameter types:
            Func<int, int> sqrExplicit = (int x) => x * x;
            Console.WriteLine(sqrFunc(3));
        }

        delegate int Transformer(int i);


    }
}
