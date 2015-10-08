using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConcreteFactoryA : Factory
    {
        public Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
