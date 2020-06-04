using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Ship
    {

        public ShipType Type { get; set; }
        public int ShipSize { get; set; }
        
        public Ship(ShipType type)
        {
            this.Type = type;
            switch (type)
            {
                case ShipType.Carrier:
                    this.ShipSize = 5;
                    break;
                case ShipType.Battleship:
                    this.ShipSize = 4;
                    break;
                case ShipType.Cruiser:
                    this.ShipSize = 3;
                    break;
                case ShipType.Submarine:
                    this.ShipSize = 2;
                    break;
                case ShipType.Destroyer:
                    this.ShipSize = 2;
                    break;

            }
        } 

        public static void displayShipTypes()
        {
            Console.WriteLine("\nAvailable ship types:\n" +
                "Carrier (occupies 5 squares) - Type: CA\n" +
                "Battleship(4) - Type: B\n" +
                "Cruiser(3) - Type: CR\n" +
                "Submarine(3) - Type: S\n" +
                "Destroyer(2) - Type: D\n");
        }




    }
}
