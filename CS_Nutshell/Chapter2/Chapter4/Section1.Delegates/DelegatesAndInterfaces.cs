using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
    // A problem that can be solved with a delegate can also be solved with an interface:

    // With interfaces, we’re forced into writing a separate type per transform
    // since Test can only implement ITransformer once:

    class DelegatesAndInterfaces
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            UtilInt.TransformAll(values, new Squarer());
            values.Dump();

            InterfacesDelegateSeparatedType();

        }

        private static void InterfacesDelegateSeparatedType()
        {
            int[] values = { 1, 2, 3 };
            UtilInt.TransformAll(values, new Cuber());
            values.Dump();
        }
    }




    // A problem that can be solved with a delegate can also be solved with an interface:

    public interface ITransformer
    {
        int Transform(int x);
    }
    
    class Squarer : ITransformer
    {
        public int Transform(int x) => x * x;
    }

    class Cuber : ITransformer
    {
        public int Transform(int x) => x * x * x;
    }

    public class UtilInt
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }
    }
}
