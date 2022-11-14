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
        public const int WINPOSITION = 100;
        public static void SnakeAndLadderGame()
        {
            int PlayerPosition =0;
            int DieCount = 0;
            //UC4
            while (PlayerPosition < WINPOSITION)
            {
                //UC2
                Random Dice = new Random();
                int diceRoll = Dice.Next(1, 7);
                Console.WriteLine("Dice Roll " + diceRoll);
                int option = Dice.Next(0, 3);
                //UC3
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Snake No Ladder");
                        Console.WriteLine("Your Position is : " + PlayerPosition);
                        break;
                    case 1:
                        PlayerPosition += diceRoll;
                        //UC5
                        if (PlayerPosition > WINPOSITION)
                        {
                            PlayerPosition -= diceRoll;
                            Console.WriteLine("Stay in some previous position " + PlayerPosition);
                        }
                        Console.WriteLine("You Got Ladder");
                        Console.WriteLine("Your Position After Ladder is : " + PlayerPosition);
                        break;
                    case 2:
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        else
                        {
                            PlayerPosition -= diceRoll;
                        }
                        Console.WriteLine("You Got Snake");
                        Console.WriteLine("Your Position After Snake is : " + PlayerPosition);
                        break;
                        DieCount++;
                }
                //UC6
                DieCount++;
            }
            //UC6
            Console.WriteLine("The Number of times Dice Rolled is " + DieCount);
        }
    }
}
