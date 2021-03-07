using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
    delegate void D1();
    delegate void D2();

    delegate void D();

    class DelegateTypeIncompatibility
    {
        static void Main(string[] args)
        {
            {
                D1 d1 = Method1;
               // D2 d2 = d1;            // Compile-time error
            }
             
            {
                D1 d1 = Method1;
                D2 d2 = new D2(d1);  // Legal
            }

            {
                // Delegate instances are considered equal if they have the same method targets:
                D d1 = Method1;
                D d2 = Method1;
                Console.WriteLine(d1 == d2);         // True
            }
        }


        static void Method1() { }
        static void Method2() { }
    }
}
