using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context a = new Context(new ConcreteStrategyA());
            Context b = new Context(new ConcreteStrategyB());

            a.ExecuteOperation();
            b.ExecuteOperation();
        }
    }
}
