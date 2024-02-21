using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations
{
    public class Observer2 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"{nameof(Observer2)} received message: {message}");
        }
    }
}
