using System;

namespace Chapter3.Section1.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            InheritanceDemo();

            PolymorphismusDemo();

            UpCastingDemo();

            // DownCastingDemo();

            Console.WriteLine("Hello World!");


            HidingInheritedMembersWithNew();

            Console.ReadKey();

        }

        private static void HidingInheritedMembersWithNew()
        {
            B b = new B();
            b.Counter.Dump();    // 2

            // Notice the non-virtual behavior in the code below:
            A referenceConvertedB = b;
            referenceConvertedB.Counter.Dump();    // 1  
        }

        private static void DownCastingDemo()
        {
            // A downcast operation creates a subclass reference from a base class reference.
            Stock msft = new Stock();
            Asset a = msft;                      // Upcast
            Stock s = (Stock)a;                  // Downcast
            Console.WriteLine(s.SharesOwned);   // <No error>
            Console.WriteLine(s == a);          // True
            Console.WriteLine(s == msft);       // True

            // A downcast requires an explicit cast because it can potentially fail at runtime:
            House h = new House();
            Asset a2 = h;               // Upcast always succeeds
            Stock s2 = (Stock)a2;       // ERROR: Downcast fails: a is not a Stock
        }

        private static void UpCastingDemo()
        {
            // An upcast creates a base class reference from a subclass reference:
            Stock msft = new Stock();
            Asset a = msft;               // Upcast
            // After the upcast, the two variables still references the same Stock object:
            Console.WriteLine(a == msft);  // True
        }



        private static void PolymorphismusDemo()
        {
            // The Display method below accepts an Asset. This means means we can pass it any subtype:
            Display(new Stock { Name = "MSFT", SharesOwned = 1000 });
            Display(new House { Name = "Mansion", Mortgage = 100000 });
        }

        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }



        private static void InheritanceDemo()
        {

            Stock msft = new Stock() { Name = "MSFT", SharesOwned = 1000 };

            Console.WriteLine(msft.Name);         // MSFT
            Console.WriteLine(msft.SharesOwned);  // 1000

            House mansion = new House() { Name = "Mansion", Mortgage = 250000 };

            Console.WriteLine(mansion.Name);      // Mansion
            Console.WriteLine(mansion.Mortgage);  // 250000
        }
    }


    public class A { public int Counter = 1; }
    public class B : A { public int Counter = 2; }

    // Occasionally, you want to hide a member deliberately, in which case you can apply the new  
    // modifier to the member in the subclass, to avoid the compiler warning. The behavior is the same:

    public class X { public int Counter = 1; }
    public class Y : X { public new int Counter = 2; }




    public class Asset
    {
        public string Name;
    }

    public class Stock : Asset   // inherits from Asset
    {
        public long SharesOwned;
    }

    public class House : Asset   // inherits from Asset
    {
        public decimal Mortgage;
    }


}
