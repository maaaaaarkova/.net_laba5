using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Interfaces
{
    public abstract class Observable
    {
        protected List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Invoke()
        {
            foreach(var observer in Observers)
            {
                observer.Handle();
            }
        }
    }
}
