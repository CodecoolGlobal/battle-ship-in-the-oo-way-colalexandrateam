using System;
using System.ComponentModel.DataAnnotations;

namespace Battleship
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Jakub");
            Player player2 = new Player("Ola");
            Board board = new Board();
            var generalBoard = board.CreateBoard();
            board.ShowBoard(generalBoard);

        }
    }
}
