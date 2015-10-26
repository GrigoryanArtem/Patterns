using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t = new Adapter(new Adaptee());
            Console.WriteLine("Info: {0}", t.Info());
        }
    }
}
