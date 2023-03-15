using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG2._0
{
    class Program
    {
        #pragma warning disable IDE0052 // Remove unread private members
        private static GameManager gm;

        static void Main()
        {
            gm = new GameManager();
            Console.ReadKey(true);
        }
    }
}
