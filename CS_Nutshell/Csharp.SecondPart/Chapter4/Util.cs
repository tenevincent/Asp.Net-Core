using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{



    class Util
    {
        // Define this to accept Func<T,TResult> instead of a custom delegate:
        public static void Transform<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }



        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);                           // Invoke delegate
                System.Threading.Thread.Sleep(100);  // Simulate hard work
            }
        }
    }



}
