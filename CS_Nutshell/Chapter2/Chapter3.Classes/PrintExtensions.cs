using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Section1.Classes
{
  public static  class PrintExtensions
    {

        public static string Dump(this object dumpOjbect)
        {
            Console.WriteLine(dumpOjbect);
            return dumpOjbect.ToString();
        }
    }
}
