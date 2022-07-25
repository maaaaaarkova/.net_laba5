using System;
using System.Collections.Generic;
using System.Text;
using Stock_exchange;
using Stock_exchange.Enums;
using StockExchange.Interfaces;

namespace StockExchange
{
    public class BuyingObserver : Observer
    {
        public override void MakeDecision(decimal price, string name)
        {
            Decision = new Decision()
            {
                Price = price,
                ExchangeName = name,
                Operation = Operation.Buy

            };

            Decision.Status = ExpectedPrice >= price ? true : false;

        }
    }
}
