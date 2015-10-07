using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component myComponent = new ConcreteComponent();
            Console.WriteLine("CC: {0}", myComponent.Operation());

            myComponent = new ConcreteDecoratorA(myComponent);
            Console.WriteLine("CC + DCA: {0}", myComponent.Operation());

            myComponent = new ConcreteDecoratorB(myComponent);
            Console.WriteLine("CC + DCB: {0}", myComponent.Operation());
        }
    }
}
