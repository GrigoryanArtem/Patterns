using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    abstract class AbstractFactory
    {
        public abstract Product.AbstractProductA CreateProductA();
        public abstract Product.AbstractProductB CreateProductB();
    }
}
