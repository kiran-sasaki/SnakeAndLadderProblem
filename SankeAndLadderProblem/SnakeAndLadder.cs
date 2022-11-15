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
            int Player1 =0;
            int Player2 =0;
            int CurrentPlayer = 1;
            int DieCount = 0;
            //UC4
            while (Player1 < WINPOSITION && Player2 < WINPOSITION)
            {
                //UC2
                Random Dice = new Random();
                int diceRoll = Dice.Next(1, 7);
                int option = Dice.Next(0, 3);
                //UC3
                switch (option)
                {
                    case NO_PLAY:
                        if (CurrentPlayer == 1)
                        {
                            Console.WriteLine("No Play");
                            Console.WriteLine(" Position of Player1 is : " + Player1);
                        }
                        else
                        {
                            Console.WriteLine("No Play");
                            Console.WriteLine(" Position of Player2 is : " + Player2);
                        }
                        break;
                    case LADDER:
                        if (CurrentPlayer == 1)
                        {
                            if (Player1 < WINPOSITION)
                            {
                                Player1 += diceRoll;
                                //UC5
                                if (Player1 > WINPOSITION)
                                {
                                    Player1 -= diceRoll;
                                    Console.WriteLine("Stay in the previous position for Player1 " + Player1);
                                }
                                Console.WriteLine("You Got Ladder");
                                Console.WriteLine("Position of Player1 After Ladder: " + Player1);
                                CurrentPlayer = 1;
                                if (Player1 == WINPOSITION)
                                {
                                    Console.WriteLine("Player1 Has Won The Game");
                                }
                            }
                        }
                        else
                        {
                            if (Player2 < WINPOSITION)
                            {
                                Player2 += diceRoll;
                                //UC5
                                if (Player2 > WINPOSITION)
                                {
                                    Player2 -= diceRoll;
                                    Console.WriteLine("Stay in the previous position for Player2 " + Player2);
                                }
                                Console.WriteLine("You Got Ladder");
                                Console.WriteLine("Position of Player2 After Ladder: " + Player2);
                                CurrentPlayer = 2;
                                if (Player2 == WINPOSITION)
                                {
                                    Console.WriteLine("Player2 Has Won The Game");
                                }
                            }
                        }
                        break;

                    case SNAKE:
                        if (CurrentPlayer == 1)
                        {
                            if (Player1 < WINPOSITION)
                            {
                                Player1 -= diceRoll;
                                if (Player1 < 0)
                                {
                                    Player1 = 0;
                                }
                                CurrentPlayer = 2;
                                Console.WriteLine("You Got Snake");
                                Console.WriteLine("Position of Player1 is: " + Player1);
                            }
                        }
                        else
                        {
                            if (Player2 < WINPOSITION)
                            {
                                Player2 -= diceRoll;
                                if (Player2 < 0)
                                {
                                    Player2 = 0;
                                }
                                CurrentPlayer = 1;
                                Console.WriteLine("You Got Snake");
                                Console.WriteLine("Position of Player2 is: " + Player2);
                            }
                        }
                        break;
                }
                //UC6
                DieCount++;
            }
            //UC6
            Console.WriteLine("The Number of times Dice Rolled is " + DieCount);
        }
    }
}
