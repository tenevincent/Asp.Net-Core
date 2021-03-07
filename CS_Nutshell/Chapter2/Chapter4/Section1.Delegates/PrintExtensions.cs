using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
  public static  class PrintExtensions
    {

        public static  void Dump(this object dumpOjbect)
        {
            Console.WriteLine(dumpOjbect);
        }

        public static void Dump(this int [] dumpOjbect)
        {
            for (int index = 0; index < dumpOjbect.Length; index++)
            {
                Console.Write(dumpOjbect[index] + " ");
            }
            Console.WriteLine();
           
        }
    }
}
