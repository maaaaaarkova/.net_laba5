using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;

namespace StockExchange
{
    public class ExchangeRate : Exchange
    {
        public ExchangeRate(Observable observable) : base(observable)
        {
        }

        public override void AnalyzeExchange()
        {
            Random random = new Random();
            decimal delta = (decimal)random.NextDouble();
            int price = random.Next(10, 100);
            Price = delta * price;

            _observable.Notify(Price, Name);
        }



    }
}
