using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.factorymethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string AnOperation()
        {     
            var product = FactoryMethod();

            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }
}
