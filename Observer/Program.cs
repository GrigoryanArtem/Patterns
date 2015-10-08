using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void PrintObserverInfo(ConcreteObserver observer)
        {
            Console.WriteLine("{0}:", observer.Name);
            foreach (var evt in observer.Events)
                Console.WriteLine("\t{0}", evt);
        }

        static void Main(string[] args)
        {
            Observable obe = new ConcreteObservable();

            ConcreteObserver concreteObserver_1 = new ConcreteObserver("ConcreteObserver_1");
            ConcreteObserver concreteObserver_2 = new ConcreteObserver("ConcreteObserver_2");
            ConcreteObserver concreteObserver_3 = new ConcreteObserver("ConcreteObserver_3");

            obe.AddObserver(concreteObserver_1);
            obe.AddObserver(concreteObserver_3);

            obe.NotifyObservers();
            obe.NotifyObservers();

            obe.RemoveObserver(concreteObserver_3);
            obe.AddObserver(concreteObserver_2);

            obe.NotifyObservers();

            obe.AddObserver(concreteObserver_3);

            obe.NotifyObservers();

            PrintObserverInfo(concreteObserver_1);
            PrintObserverInfo(concreteObserver_2);
            PrintObserverInfo(concreteObserver_3);
        }
    }
}
