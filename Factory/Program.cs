using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new ConcreteFactoryA();
            Product product;

            product = factory.CreateProduct();
            Console.WriteLine("Created: {0}.", product.GetType());

            factory = new ConcreteFactoryB();

            product = factory.CreateProduct();
            Console.WriteLine("Created: {0}.", product.GetType());
        }
    }
}
