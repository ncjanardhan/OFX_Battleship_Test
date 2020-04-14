using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGame
{
    public class BattlefieldGameplay
    {
        public BattlefieldState BattlefieldStatePlayerA { get; set; }

        public BattlefieldState BattlefieldStatePlayerB { get; set; }

        public BattlefieldGameplay()
        {
            this.BattlefieldStatePlayerA = new BattlefieldState();
            this.BattlefieldStatePlayerB = new BattlefieldState();
        }
        
        public bool PlaceShip(Player player, int row, int column, string shipName,
                int shipSize, ShipPlacementOrientation orientation)
        {
            int rowCounter = row, columnCounter = column;
            bool isValidPlacement = true;

            BattlefieldState battlefieldState = (player == Player.A) ? BattlefieldStatePlayerA : BattlefieldStatePlayerB;

            var node = battlefieldState.Nodes[rowCounter, columnCounter];

            List<Node> placedNodes = new List<Node>();

            ShipPlacement shipPlacement = new ShipPlacement
            {
                StartingNode = node,
                ShipName = shipName,
                ShipSize = shipSize
            };

            if (
                (orientation == ShipPlacementOrientation.Horizontal && column + shipSize > Constants.BATTLEFIELD_SIZE) ||
                (orientation == ShipPlacementOrientation.Vertical && row + shipSize > Constants.BATTLEFIELD_SIZE)
                )
            {
                isValidPlacement = false;
            }

            if (isValidPlacement != false)
            {
                for (int i = 0; i < shipSize; i++)
                {                    
                    node = battlefieldState.Nodes[rowCounter, columnCounter];

                    if (node.OccupiedByShip == true)
                    {
                        isValidPlacement = false;
                        break;
                    }
                    else
                    {
                        placedNodes.Add(node);
                    }

                    if (orientation == ShipPlacementOrientation.Horizontal)
                    {
                        columnCounter++;
                    }
                    else
                    {
                        rowCounter++;
                    }
                }
            }

            if (isValidPlacement == true)
            {
                foreach (var item in placedNodes)
                {
                    item.OccupiedByShip = true;

                    shipPlacement.NodesOfShip.Add(item);
                }

                battlefieldState.ShipPlacements.Add(shipPlacement);
            }

            return isValidPlacement;
        }

        public bool PlaceHit(Player playerSendingTheHit, int row, int column)
        {
            BattlefieldState battlefieldStateOfTargetPlayer;

            if (playerSendingTheHit == Player.A)
            {
                battlefieldStateOfTargetPlayer = this.BattlefieldStatePlayerB;
            }
            else
            {
                battlefieldStateOfTargetPlayer = this.BattlefieldStatePlayerA;
            }

            battlefieldStateOfTargetPlayer.Nodes[row, column].HitByEnemy = true;

            return true;
        }
    }
}
