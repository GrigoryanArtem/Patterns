using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        private string _name;
        private List<string> _events;

        public ConcreteObserver(string name)
        {
            _name = name;
            _events = new List<string>();
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public List<string> Events
        {
            get
            {
                return _events;
            }
        }

        public void Update(string eventName)
        {
            _events.Add(eventName);
        }
    }
}
