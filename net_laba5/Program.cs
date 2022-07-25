using System;
using StockExchange;
using StockExchange.Interfaces;

namespace net_laba5
{
    public class Program
    {
        static void Main()
        {

            Observer observer1 = new BuyingObserver()
            {
                Name = "observer1",
                ExpectedPrice = 25            
            };

            Observer observer2 = new SellingObserver()
            {
                Name = "observer2",
                ExpectedPrice = 40000
            };

            Observable observable1 = new Observable();
            observable1.Subscribe(observer1);
            Observable observable2 = new Observable();
            observable2.Subscribe(observer2);

            Exchange exchangeRate1 = new ExchangeRate(observable1)
            {
                Name = "Dollar",
            };

            Exchange quotes1 = new Quotes(observable2)
            {
                Name = "Quote1"
            };

            Console.WriteLine("Press Enter to update exchange rates \n");
            Console.WriteLine("Press Escape to exit \n");

            var key = ConsoleKey.Enter;

            while (key == ConsoleKey.Enter)
            {
                exchangeRate1.AnalyzeExchange();
                Console.WriteLine($"{observer1.Name} : {observer1.Decision}");

                quotes1.AnalyzeExchange();
                Console.WriteLine($"{observer2.Name} : {observer2.Decision}");

                key = Console.ReadKey().Key;
            }
        }
    }
}
