using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGame
{
    public class BattlefieldState
    {
        public Node[,] Nodes { get; set; }
        public List<ShipPlacement> ShipPlacements { get; set; } = new List<ShipPlacement>();

        public BattlefieldState()
        {
            this.Nodes = new Node[Constants.BATTLEFIELD_SIZE, Constants.BATTLEFIELD_SIZE];

            for (int row = 0; row < Constants.BATTLEFIELD_SIZE; row++)
            {
                for (int col = 0; col < Constants.BATTLEFIELD_SIZE; col++)
                {
                    this.Nodes[row, col] = new Node { Row = row + 1, Column = col + 1, HitByEnemy = false };
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int row = 0; row < Constants.BATTLEFIELD_SIZE; row++)
            {
                for (int col = 0; col < Constants.BATTLEFIELD_SIZE; col++)
                {
                    var node = this.Nodes[row, col];

                    string nodeRepresentation = ".";

                    if (node.OccupiedByShip)
                    {
                        nodeRepresentation = "S";
                    }

                    if (node.HitByEnemy)
                    {
                        nodeRepresentation = "H";
                    }

                    if (node.HitByEnemy && node.OccupiedByShip)
                    {
                        nodeRepresentation = "X";
                    }

                    stringBuilder.Append("         " + nodeRepresentation);
                }

                stringBuilder.AppendLine();
            }

            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("-----------------Ships-----------------");

            foreach (var ship in this.ShipPlacements)
            {
                stringBuilder.AppendLine(ship.ShipName + " - " + ship.IsShipCompletelyHit);
            }

            return stringBuilder.ToString();
        }        
    }

}
