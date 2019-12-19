using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BattlePlayer shlomo = new BE.BattlePlayer
            {
                Name = "winner"
            };
            shlomo[0, 0] = true;
            shlomo[0, 1] = true;
            shlomo[0, 1] = true;
            shlomo[0, 1] = true;
            shlomo[9, 0] = true;
            shlomo.fire(2, 3);
            Console.WriteLine(shlomo);

            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey();
        }
    }
}
