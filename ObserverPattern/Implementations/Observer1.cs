using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementations
{
    public class Observer1 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"{nameof(Observer1)} received message: {message}");
        }
    }
}
