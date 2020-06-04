using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Board
    {

        public int[,] CreateBoard()
        {
            int[,] boardShip = new int [10, 10];
            return boardShip;

        }

        public void ShowBoard(int[,] shipBoard)
        {
            List<int> firstLine = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> vertLine = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            Console.Write("     ");
            foreach (int num in firstLine)
            {
                Console.Write("  " + num + "   ");
            }
            Console.WriteLine();

            for (int row = 0 ; row < shipBoard.GetLength(0); row++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(vertLine[row]);
                for (int column = 0; column < shipBoard.GetLength(1); column++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  |  ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(shipBoard[row, column]);
                    
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  |  ");
                Console.WriteLine();
                Console.WriteLine("    ------------------------------------------------------------");

            }
        }
    }
}
