using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
    // A delegate type may contain generic type parameters:
    public delegate T Transformer<T>(T arg);



    class GenericDelegates
    {
        static void Main(string[] args)
        {

            int[] values = { 1, 2, 3 };
            UtilGeneric.Transform(values, Square);      // Dynamically hook in Square
            values.Dump();
        }


        static int Square(int x) => x * x;

    }



    // With this definition, we can write a generalized Transform utility method that works on any type:
    public class UtilGeneric
    {
        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }

}
