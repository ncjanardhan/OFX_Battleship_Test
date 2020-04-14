using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGame
{
    public static class Constants
    {
        public const int BATTLEFIELD_SIZE = 10;        
    }

    public static class Destroyer
    {
        public const int ShipSize = 2;
        public const string ShipName = "DESTROYER";
    }

    public static class Submarine
    {
        public const int ShipSize = 3;
        public const string ShipName = "SUBMARINE";
    }

    public static class Cruiser
    {
        public const int ShipSize = 3;
        public const string ShipName = "CRUISER";
    }

    public static class Battleship
    {
        public const int ShipSize = 4;
        public const string ShipName = "BATTLESHIP";
    }

    public static class Carrier
    {
        public const int ShipSize = 5;
        public const string ShipName = "CARRIER";
    }
}
