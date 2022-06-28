using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;

namespace StockExchange
{
    public class ExchangeRateObservable : Observable
    {
        public decimal Price;
        public decimal ExpectedPrice;

        public void AnalyzeExchangeRate()
        {
            Random random = new Random();
            decimal delta = (decimal)random.NextDouble();
            Price += delta;
            if (Price >= ExpectedPrice)
            {
                Invoke();
            }
        }


    }
}
