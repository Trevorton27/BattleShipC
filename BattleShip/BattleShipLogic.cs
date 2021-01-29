using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleShipLogic
    {
        public int HitCount { get; set; }
        public int X_axis { get; set; }
        public int Y_axis { get; set; }

   
        public BattleShipLogic()
        {
            SetPosition();
            Console.WriteLine();
        }
        public void SetPosition()
        {
            var placeBattleShip = new Random();
            X_axis = placeBattleShip.Next(1, 11);
            Y_axis = placeBattleShip.Next(1, 11);
        }

     
    }

  
}
