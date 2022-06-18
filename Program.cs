using System;
using multiGames;

namespace multiGames
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu Menu = new Menu();
            bool disPlayMenu = true;
            while (disPlayMenu)
            {
                disPlayMenu = Menu.MainMenu();
            }


        }

       
       
        
    }
}
