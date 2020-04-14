using System;

namespace BattlefieldGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************* ");
            Console.WriteLine("********************* Battlefield ********************* ");
            Console.WriteLine("******************************************************* \n\n\n");

            //Start Game
            BattlefieldGameplay battlefieldGameplay = new BattlefieldGameplay();

            battlefieldGameplay.PlaceShip(Player.A, 5, 1, Cruiser.ShipName, Cruiser.ShipSize, ShipPlacementOrientation.Vertical);
            battlefieldGameplay.PlaceShip(Player.A, 9, 2, Battleship.ShipName, Battleship.ShipSize, ShipPlacementOrientation.Horizontal);
            battlefieldGameplay.PlaceShip(Player.A, 2, 2, Destroyer.ShipName, Destroyer.ShipSize, ShipPlacementOrientation.Horizontal);
            battlefieldGameplay.PlaceShip(Player.A, 3, 7, Submarine.ShipName, Submarine.ShipSize, ShipPlacementOrientation.Horizontal);
            battlefieldGameplay.PlaceShip(Player.A, 4, 2, Carrier.ShipName, Submarine.ShipSize, ShipPlacementOrientation.Vertical);

            battlefieldGameplay.PlaceHit(Player.B, 4, 5);
            battlefieldGameplay.PlaceHit(Player.B, 7, 8);
            battlefieldGameplay.PlaceHit(Player.B, 4, 2);
            battlefieldGameplay.PlaceHit(Player.B, 5, 2);
            battlefieldGameplay.PlaceHit(Player.B, 6, 2);
            battlefieldGameplay.PlaceHit(Player.B, 5, 6);
            battlefieldGameplay.PlaceHit(Player.B, 9, 9);

            Console.WriteLine("Player A has placed the ships \nPlayer B has made 7 hits & destroyed one ship: \n");

            Console.WriteLine("State of Player A:");
            Console.Write(battlefieldGameplay.BattlefieldStatePlayerA.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
