using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
   public class NullOperators
    {
      public  static void Main(string[] args)
        {

            {
                string s1 = null;
                string s2 = s1 ?? "The string is null";   // s2 evaluates to "nothing"
                Console.WriteLine(s2);

 
            }

            {
               StringBuilder sb = null;
                string s = sb?.ToString();   // No error; s instead evaluates to null
                string s2 = sb?.ToString().ToUpper();   // s evaluates to null without error
                Console.WriteLine("Second print: " + s2);


            }

            Console.ReadKey();
        }
    }
}
