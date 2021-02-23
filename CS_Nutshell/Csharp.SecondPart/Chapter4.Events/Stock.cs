using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Events
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);


    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) { this.symbol = symbol; }

        public event PriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;      // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null)      // If invocation list not empty,
                    PriceChanged(oldPrice, price);  // fire event.
            }
        }
    }
}
