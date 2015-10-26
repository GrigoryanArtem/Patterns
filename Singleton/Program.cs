using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static public void PrintValue(int value)
        {
            Console.WriteLine("Value: {0}", value);
        }

        static void Main(string[] args)
        {
            Singleton a = Singleton.Instance;

            PrintValue(a.Count);
            
            a.Add();
            PrintValue(a.Count);

            Singleton b = Singleton.Instance;
            PrintValue(b.Count);

            b.Add();
            PrintValue(a.Count);
        }
    }
}
