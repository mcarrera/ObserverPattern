using ObserverPattern.Implementations;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ob1 = new Observer1();
            var ob2 = new Observer2();

            var pub = new Publisher();
            pub.RegisterObserver(ob1);
            pub.RegisterObserver(ob2);

            pub.Run();
        }

       
    }
}
