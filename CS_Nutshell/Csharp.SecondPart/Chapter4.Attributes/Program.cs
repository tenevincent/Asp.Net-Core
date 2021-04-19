using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Chapter4.Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            new Foo();   // Generates a warning because Foo is obsolete


            FooCall();


            Console.ReadKey();
        }

        static void FooCall(
  [CallerMemberName] string memberName = null,
  [CallerFilePath] string filePath = null,
  [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }



    }

    [XmlType("Customer", Namespace = "http://oreilly.com")]
    public class CustomerEntity
    {
    }



    [Obsolete]
    public class Foo
    {
    }


}
