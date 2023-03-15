using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG2._0
{
    class GameManager : System
    {
        private bool isRunning = true;

        public GameManager()
        {
            UserInput();
        }

        protected override void OnTick()
        {
            Console.WriteLine("1");
        }

        private void UserInput()
        {
            while (isRunning)
            {
                Console.ReadKey();
            }
        }
    }
}
