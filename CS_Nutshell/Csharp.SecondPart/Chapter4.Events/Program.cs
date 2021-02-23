using ConsoleDump;
using System;

namespace Chapter4.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleEvent();

            UsingStandardEventPattern();


            Console.WriteLine("Hello World!");
        }

        private static void SimpleEvent()
        {
            var stock = new Stock("MSFT");
            stock.PriceChanged += ReportPriceChange;
            stock.Price = 123;
            stock.Price = 456;
        }

        private static void UsingStandardEventPattern()
        {
            Stock2 stock = new Stock2("THPW");
            stock.Price = 27.10M;
            // Register with the PriceChanged event
            stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;

            void stock_PriceChanged(object sender, PriceChangedEventArgs e)
            {
                if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                    Console.WriteLine("Alert, 10% stock price increase!");
            }

        }

        static void ReportPriceChange(decimal oldPrice, decimal newPrice)
        {
            ("Price changed from " + oldPrice + " to " + newPrice).Dump();
        }


    }
}
