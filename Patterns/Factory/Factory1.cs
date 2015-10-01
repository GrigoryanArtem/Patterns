using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class Factory1 : AbstractFactory
    {
        public override Product.AbstractProductA CreateProductA()
        {
            return new Product.ProductA1();
        }

        public override Product.AbstractProductB CreateProductB()
        {
            return new Product.ProductB1();
        }
    }
}
