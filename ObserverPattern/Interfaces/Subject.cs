namespace ObserverPattern.Interfaces
{
    interface Subject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers(string message);
    }
}
