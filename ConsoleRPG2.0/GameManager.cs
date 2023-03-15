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
            Draw();
            UserInput();
        }

        protected override void OnTick()
        {
            Update();
            Draw();
            Console.Write("1");
        }

        private void Update()
        {

        }

        private void Draw()
        {
            Console.SetCursorPosition(0, 0);
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
