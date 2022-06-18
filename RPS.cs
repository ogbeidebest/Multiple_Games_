using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiGames
{
    public class RPS
    {
        public void RockPapperScissors()
        {
            Console.Clear();
            Random ramdom = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;


            while (playAgain)
            {
                Console.Clear();
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                // Console.WriteLine(player);

                int randomNum = ramdom.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It is a draw!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!!");
                        }
                        else
                        {
                            Console.WriteLine("You Win");
                        }
                        break;

                    case "PAPER":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine(" You Win");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It is a Draw!!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw");
                        }
                        break;


                }
                Console.Write("Would you like to play again? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playAgain = true;

                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for Playing");
        }
    }
}
