using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Interfaces
{
    public interface IObserver
    {
        void Handle();
    }
}
