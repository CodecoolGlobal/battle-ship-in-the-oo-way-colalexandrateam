using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class ShipControler
    {
        public static Directions ToDirections(int x, int y)
        {
            return (x, y) switch
            {
                (1, 0) => Directions.Right,
                (-1, 0) => Directions.Left,
                (0, 1) => Directions.Down,
                (0, -1) => Directions.Up,
                (-1, -1) => Directions.LeftUp,
                (1, -1) => Directions.RightUp,
                (-1, 1) => Directions.LeftDown,
                (1, 1) => Directions.RightDown,
                _ => throw new ArgumentOutOfRangeException()

            };
        }

        public bool InMapBorders(int[,] board, int column, int row)
        {
            return column <= 0 || column >= board.GetLength(1) || row <= 0 || row >= board.GetLength(0);
        }

        public bool IsX(int[,] board, int column, int row)
        {
            return board[row, column] == 'X';
        }

        public bool IsQ(int[,] board, int column, int row)
        {
            return board[row, column] == 'q';
        }

        public bool IsSee(int[,] board, int column, int row)
        {
            return board[row, column] == 0;
        }

        public bool isVertical(Directions directions)
        {
            return directions == Directions.Up || directions == Directions.Down;

        }

        public bool isHorizontal(Directions directions)
        {
            return directions == Directions.Left || directions == Directions.Right;
        }

        public Directions DefineVector(int x, int deltaX, int y, int deltaY)
        {
            Directions[] dirs = new Directions[]
            {
                Directions.Down, Directions.Left, Directions.LeftDown, Directions.LeftUp, Directions.Right, Directions.RightDown, Directions.RightUp, Directions.Up
            };

            var direction = dirs[0];

            for (int i = 0; i < dirs.Length; i++)
            {
                if (dirs[i] == ToDirections(x - deltaX, y - deltaY))
                {
                    direction = dirs[i];
                }
            }
            return direction;

        }
    }
}
