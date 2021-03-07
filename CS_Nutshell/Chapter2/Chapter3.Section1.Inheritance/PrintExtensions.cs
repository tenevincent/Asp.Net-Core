using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Section1.Inheritance
{
  public static  class PrintExtensions
    {

        public static  void Dump(this object dumpOjbect)
        {
            Console.WriteLine(dumpOjbect);
        }
    }
}
