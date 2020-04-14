using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGame
{
    public class ShipPlacement
    {
        public string ShipName { get; set; }
        public Node StartingNode {get; set;}
        public int ShipSize { get; set; }

        public bool IsShipCompletelyHit
        {
            get
            {
                return this.NodesOfShip.TrueForAll(n => n.HitByEnemy == true);
            }
        }

        public List<Node> NodesOfShip { get; set; } = new List<Node>();
    }
}
