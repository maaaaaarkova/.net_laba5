using System;
using System.Collections.Generic;
using System.Text;
using StockExchange.Interfaces;

namespace StockExchange
{ 
    public class Observable
    {
        protected List<Observer> Observers { get; set; } = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(decimal price, string name)
        {
            foreach(var observer in Observers)
            {
                observer.MakeDecision(price, name);
            }
        }
    }
}
