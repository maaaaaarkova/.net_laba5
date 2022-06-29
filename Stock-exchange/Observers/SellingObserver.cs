using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;

namespace StockExchange
{
    public class SellingObserver : Observer
    {
        public override void MakeDecision(decimal price, string name)
        {
            if (ExpectedPrice <= price)
            {
                Decision = $"{Name} wants to sell {name} with price {decimal.Round(price, 2)}";
            }

            else
            {
                Decision = "No decision";
            }
        }
    }
}
