using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private int count;

        protected Singleton()
        {
            count = 0;
        }

        sealed private class SingletonCreated{
            static private readonly Singleton instance = new Singleton();

            static public Singleton Instance
            {
                get
                {
                    return instance;
                }
            }
        }

        static public Singleton Instance{
            get
            {
                return SingletonCreated.Instance;
            }
        }

        public void Add()
        {
            count++;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
