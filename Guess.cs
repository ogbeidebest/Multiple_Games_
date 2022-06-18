using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiGames
{
    public class Guess
    {
        public void GuessingGame()
        {
            Console.Clear();
            bool playAgain = true;
            string answer;
            while (playAgain)
            {
                Console.WriteLine("Guess game");
                Random myRandom = new Random();
                int randomNumbner = myRandom.Next(1, 11);
                int guesses = 0;
                bool incorrect = true;
                do
                {
                    Console.WriteLine("Guess a number between 1 and 10");
                    string result = Console.ReadLine();
                    guesses++;
                    if (result == randomNumbner.ToString())
                    {
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!!");
                    }
                } while (incorrect);
                {
                    Console.WriteLine("Correct!! it took you {0} guesses", guesses);
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
