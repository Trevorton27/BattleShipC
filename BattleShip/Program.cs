using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleShipLogic = new BattleShipLogic();
            Console.WriteLine(battleShipLogic.SetPostion());
        }
    }
}
