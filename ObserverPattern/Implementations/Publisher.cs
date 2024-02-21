using ObserverPattern.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementations
{
    internal class Publisher : Subject
    {
        private readonly ConcurrentDictionary<IObserver, bool> Observers;

        public Publisher()
        {
            Observers = new ConcurrentDictionary<IObserver, bool>();
        }

        public void Run()
        {
            // runs 3 times when the second is multiple of 5
            var counter = 0;
            
            while (counter < 3)
            {
                var now = DateTime.Now;
                if (now.Second % 5 == 0)
                {
                    NotifyObservers(now.ToString("hh:mm:ss"));
                    counter++;
                    Thread.Sleep(1000);
                }

            }
        }


        public void NotifyObservers(string message)
        {
            foreach (var item in Observers.Keys)
            {
                item.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.TryAdd(observer, true);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.TryRemove(observer, out _);
        }
    }
}
