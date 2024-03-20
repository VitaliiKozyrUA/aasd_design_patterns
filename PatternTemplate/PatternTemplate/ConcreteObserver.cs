using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.observer
{
    class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("ConcreteObserver received an update.");
        }
    }
}
