﻿using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleShipLogic = new BattleShipLogic();
            var gameFeedBackLogic = new GameFeedBackLogic();

            gameFeedBackLogic.WelcomeMessage();
            gameFeedBackLogic.GameExplanation();
        }
    }
}
