using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Observable
    {
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObservers();
    }
}
