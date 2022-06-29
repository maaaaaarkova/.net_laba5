using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;
using System.Threading;

namespace StockExchange
{
    public class Quotes : Exchange
    {
        public Quotes(Observable observable) : base(observable)
        {
        }

        public override void AnalyzeExchange()
        {
            Random random = new Random();
            decimal delta = (decimal)random.NextDouble();
            int price = random.Next(10000, 100000);
            Price = delta * price;

            _observable.Notify(Price, Name);
        }

    }
}
