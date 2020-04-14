using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGame
{
    public class Node
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool HitByEnemy { get; set; }
        public bool OccupiedByShip { get; set; }
    }
}
