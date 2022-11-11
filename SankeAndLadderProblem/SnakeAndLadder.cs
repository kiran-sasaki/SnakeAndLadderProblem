using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public static class SnakeAndLadder
    {
        public static void SnakeAndLadderGame()
        {
            int StartPosition = 0;
            Console.WriteLine("Started with " + StartPosition + " position");
            Random Dice = new Random();
            int diceRoll = Dice.Next(1, 7);
            Console.WriteLine("Dice Roll " + diceRoll);
        }
    }
}
