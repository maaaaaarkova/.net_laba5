using System;
using System.Collections.Generic;
using System.Text;
using Stock_exchange.Enums;

namespace Stock_exchange
{
    public class Decision
    {
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public string ExchangeName { get; set; }
        public Operation Operation { get; set; }
        public override string ToString()
        {
            return Status == true ? $"Observer wants to {Operation} {ExchangeName} with price {decimal.Round(Price, 2)}" : "No decision";
        }
    }
}
