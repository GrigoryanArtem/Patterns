using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObservable : Observable
    {
        private int _numberOfEvents;
        private List<Observer> _observers;

        public ConcreteObservable()
        {
            _numberOfEvents = 0;
            _observers = new List<Observer>();
        }

        public int NumberOfEvents{
            get
            {
                return _numberOfEvents;
            }
        }

        public List<Observer> Observers
        {
            get
            {
                return _observers;
            }
        }
        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _numberOfEvents++;

            foreach (var observer in _observers)
                observer.Update(CreateInfoString());
        }

        private string CreateInfoString()
        {
            return String.Format("Event #{0}.", _numberOfEvents);
        }
    }
}
