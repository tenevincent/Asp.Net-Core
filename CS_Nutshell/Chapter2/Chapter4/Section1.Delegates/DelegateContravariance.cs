using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
    delegate void StringAction(string s);
    // A delegate can have more specific parameter types than its method target. This is called contravariance:



    // A delegate can have more specific parameter types than its method target. This is called contravariance:
    delegate object ObjectRetriever();

    class DelegateContravariance
    {

        static void Main(string[] args)
        {
            DelegateSpecificParameter();


            DelegateCovoriance();
        }

        private static void DelegateCovoriance()
        {
            ObjectRetriever o =  RetriveString;
            object result = o();
            Console.WriteLine(result);      // hello
        }

        private static void DelegateSpecificParameter()
        {
            StringAction sa = ActOnObject;
            sa("hello");
        }

        static void ActOnObject(object o) => Console.WriteLine(o);   // hello

        static string RetriveString() => "hello";
    }
}
