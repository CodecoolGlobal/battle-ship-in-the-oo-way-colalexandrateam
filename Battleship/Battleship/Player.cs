using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Player
    {
        public Board Ocean { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public Dictionary<string, int> TableSign = new Dictionary<string, int>()
        {
            { "A", 0 },
            { "B", 1 },
            { "C", 2 },
            { "D", 3 },
            { "E", 4 },
            { "F", 5 },
            { "G", 6 },
            { "H", 7 },
            { "I", 8 },
            { "J", 9 },

        };

        

        public List<List<int>> GetShipsCoordiantesFromInput()
            {
                List<List<int>> CoordinatesList = new List<List<int>>();
                Console.WriteLine("Give the row letter(space) and column number");
                string input = Console.ReadLine();
                string[] inputSplit = input.Split(" ");

                int column;
                int row = TableSign[inputSplit[0]];
                bool resultColumn = int.TryParse(inputSplit[1], out column);
                CoordinatesList.Add(new List<int> { row, column });
                return CoordinatesList;
            }



    }
}
