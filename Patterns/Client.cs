using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private Product.AbstractProductA apa;
        private Product.AbstractProductB apb;

        public Client(Factory.AbstractFactory apf)
        {
            apa = apf.CreateProductA();
            apb = apf.CreateProductB();
        }

        public void Perform()
        {
            Console.WriteLine(apb.Interact(apa));
        }
    }
}
