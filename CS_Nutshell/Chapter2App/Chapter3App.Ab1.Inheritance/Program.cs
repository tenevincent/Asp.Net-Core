using System;

namespace Chapter3App.Ab1.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 9;
            object obj = x; // Box the int



                            //// An upcast creates a base class reference from a subclass reference:
                            //Stock msft = new Stock();
                            //Asset a = msft;               // Upcast
                            //// After the upcast, the two variables still references the same Stock object:
                            //Console.WriteLine(a == msft);  // True




            // DisplayPolymorphismus();

            Console.ReadKey();
        }

        private static void DisplayPolymorphismus()
        {
            // The Display method below accepts an Asset. This means means we can pass it any subtype:
            Display(new Stock { Name = "MSFT", SharesOwned = 1000 });
            Display(new House { Name = "Mansion", Mortgage = 100000 });
        }

        static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }


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
}
