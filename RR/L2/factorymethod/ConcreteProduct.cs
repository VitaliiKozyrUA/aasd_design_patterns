using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.factorymethod
{
    public class ConcreteProduct : IProduct
    {
        public string Operation()
        {
            return "Result of ConcreteProduct";
        }
    }
}
