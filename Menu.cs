using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiGames
{
    public class Menu
    {
        
        Guess Guess = new Guess();
        RPS RPS = new RPS();    
        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter an option: ");
            Console.WriteLine("1) Paper, Rock, Scissor");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                RPS.RockPapperScissors();
                return true;
            }
            else if (result == "2")
            {
                Guess.GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
