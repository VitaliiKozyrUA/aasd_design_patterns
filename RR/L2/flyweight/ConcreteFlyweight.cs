using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.flyweight
{
    public class ConcreteFlyweight : IFlyweight
    {
        string _intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            this._intrinsicState = intrinsicState;
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyweight: IntrinsicState {_intrinsicState}, ExtrinsicState {extrinsicState}");
        }
    }
}
