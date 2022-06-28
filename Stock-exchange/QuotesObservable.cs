using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;
using System.Threading;

namespace StockExchange
{
    public class QuotesObservable : Observable
    {
        public decimal Price;
        public decimal ExpectedPrice;

        public void AnalyzeQuote()
        {
            Random random = new Random();
            decimal delta = (decimal)random.NextDouble();
            Price += delta;
            Thread.Sleep(millisecondsTimeout: 1000);
            if (Price >= ExpectedPrice)
            {
                Invoke();
            }
        }

        public void Invoke()
        {

        }
    }
}
