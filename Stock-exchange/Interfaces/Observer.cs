using System;
using System.Collections.Generic;
using System.Text;
using Stock_exchange;

namespace StockExchange.Interfaces
{
    public abstract class Observer
    {
        public string Name { get; set; }

        public Decision Decision { get; protected set; }

        public decimal ExpectedPrice { get; set; }

        public abstract void MakeDecision(decimal price, string name);
    }
}
