using System;
using System.Collections.Generic;
using System.Text;
using Stock_exchange;
using Stock_exchange.Enums;
using StockExchange.Interfaces;

namespace StockExchange
{
    public class SellingObserver : Observer
    {
        public override void MakeDecision(decimal price, string name)
        {
            Decision = new Decision()
            {
                Price = price,
                ExchangeName = name,
                Operation = Operation.Sell

            };

            Decision.Status = ExpectedPrice <= price ? true : false;

        }
    }
}
