using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Interfaces
{
    public abstract class Observer
    {
        public string Name { get; set; }

        public string Decision { get; protected set; } = "No decision";

        public decimal ExpectedPrice { get; set; }

        public abstract void MakeDecision(decimal price, string name);
    }
}
