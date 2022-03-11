using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambler_Game
{
    internal class Gambler
    {
        //CONSTANTS(All Amounts mentioned in dollars)
        public const int DAILYINITIALSTAKE = 100;
        public const int BETPERGAME = 1;
        public const int WIN = 1;
        public const int LOOSE = 0;

        //VARIABLES
        int remainingStake = DAILYINITIALSTAKE;

        public void CheckWinOrLoose()
        {
            Random random = new Random();
            int winOrLooseCheck = random.Next(0, 2);
            switch (winOrLooseCheck)
            {
                case WIN:
                    Console.WriteLine("Player wins");
                    remainingStake = remainingStake + 1;
                    break;
                default:
                    Console.WriteLine("Player looses");
                    remainingStake = remainingStake - 1;
                    break;
            }
            Console.WriteLine($"Gambler is having now {remainingStake}");
        }
    }
}
