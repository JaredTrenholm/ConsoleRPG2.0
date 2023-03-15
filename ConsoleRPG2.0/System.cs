using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleRPG2._0
{
    abstract class System
    {
        static System sys = null;
        Thread tick = new Thread(Tick);
        protected System()
        {
            if(sys == null)
            {
                sys = this;
                tick.Start();
            }
        }

        private static void Tick()
        {
            while (true)
            {
                sys.OnTick();
                Thread.Sleep(0);
            }
        }

        protected abstract void OnTick();
    }
}
