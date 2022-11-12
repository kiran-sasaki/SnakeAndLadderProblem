using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public static class SnakeAndLadder
    {
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        public const int EndPosition = 100;
        public static void SnakeAndLadderGame()
        {
            int StartPosition = 0;
            int PlayerPosition =0;
            Console.WriteLine("Started with " + StartPosition + " position");
            //UC2
            Random Dice = new Random();
            int diceRoll = Dice.Next(1, 7);
            Console.WriteLine("Dice Roll " + diceRoll);
            //UC3
            int option = Dice.Next(0, 3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Snake No Ladder");
                    Console.WriteLine("Your Position is : " + PlayerPosition);
                    break;
                case 1:
                    PlayerPosition += diceRoll;
                    Console.WriteLine("You Got Ladder");
                    Console.WriteLine("Your Position After Ladder is : " + PlayerPosition);
                    break;
                case 2:
                    PlayerPosition -= diceRoll;
                    Console.WriteLine("You Got Snake");
                    Console.WriteLine("Your Position After Snake is : " + PlayerPosition);
                    break;
            }
        }
    }
}
