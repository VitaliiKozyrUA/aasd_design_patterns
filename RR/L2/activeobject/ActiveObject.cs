using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.activeobject
{
    public class ActiveObject
    {

        private BlockingCollection<Action> dispatchQueue = new BlockingCollection<Action>();
        public double val = 0.0;

        public ActiveObject()
        {
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        dispatchQueue.Take().Invoke();
                    }
                }
                catch (InvalidOperationException)
                {

                }
            });
        }

        public void DoSomething()
        {
            dispatchQueue.Add(() => val = 1.0);
        }

        public void DoSomethingElse()
        {
            dispatchQueue.Add(() => val = 2.0);
        }
    }
}
