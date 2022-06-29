using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Interfaces
{
    public abstract class Exchange
    {
        protected readonly Observable _observable;
        public decimal Price { get; protected set; }
        public string Name { get; set; }
        public Exchange(Observable observable)
        {
            _observable = observable;
        }

        public abstract void AnalyzeExchange();

    }
}
