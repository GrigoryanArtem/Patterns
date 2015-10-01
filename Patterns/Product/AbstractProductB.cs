using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    abstract class AbstractProductB
    {
        public override string ToString()
        {
            return "Abstract product B";
        }

        public string Interact(AbstractProductA apa)
        {
            return string.Format("{0} + {1}.", ToString(), apa.ToString());
        } 
    }
}
