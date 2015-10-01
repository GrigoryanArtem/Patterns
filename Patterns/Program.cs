using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client temp = new Client(new Factory.Factory1());
            temp.Perform();

            temp = new Client(new Factory.Factory2());
            temp.Perform();
        }
    }
}
