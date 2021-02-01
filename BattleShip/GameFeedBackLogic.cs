using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BattleShip
{
    class GameFeedBackLogic
    {
      public void WelcomeMessage() 
        {
        WriteLine("Hey there. Welcome to the classic game of Battle Ship.");
            WriteLine();
            WriteLine("Press Enter to continue");
        }

        public void GameExplanation() 
            {
        var button = ReadKey();
            if (button.Key == ConsoleKey.Enter)
                {
            WriteLine("You have 8 missiles to fire at the Battle Ship.");
                WriteLine();
                WriteLine("You must hit the Battle Ship 5 times to sink it.");
                WriteLine();
                WriteLine("Are you ready?");
                WriteLine();
                WriteLine("If yes, press enter to continue.");
                WriteLine("Otherwise press escape to exit the program and close this window.");

                var startGameButton = ReadKey();
                var endGameButton = ReadKey();

                if (startGameButton.Key == ConsoleKey.Enter) 
                    {
                //start game
                }

                if ( endGameButton.Key == ConsoleKey.Escape) 
                    {
                //exit program
                 System.Environment.Exit(0);  
                }
            }
        }
    }
}
