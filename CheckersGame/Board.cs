using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class Board
    {
        private const int COLUMNS = 8;
        private const int ROWS = 8;
        private Square[,] squares = new Square[COLUMNS, ROWS];

        /**
         * Creates an empty board
         */
        public Board()
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                for (int row = 0; row < ROWS; row++)
                {
                    squares[column, row] = new Square(new Location(row, column));
                }
            }
        }

        public void SetUpBoard(Color computerColor, Color playerColor)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                //computer rows
                int firstRow = 0;
                int secondRow = 1;
                int thirdRow = 2;

                //user rows
                int sixthRow = 5;
                int seventhRow = 6;
                int eighthRow = 7;

                if (column % 2 == 0)
                {
                    squares[column, secondRow].Piece = (new RegularPiece(new Location(secondRow, column), computerColor, PlayerType.Player.Computer));
                    squares[column, sixthRow].Piece = (new RegularPiece(new Location(sixthRow, column), playerColor, PlayerType.Player.User));
                    squares[column, eighthRow].Piece = (new RegularPiece(new Location(eighthRow, column), playerColor, PlayerType.Player.User));
                }
                else
                {
                    squares[column, firstRow].Piece = (new RegularPiece(new Location(firstRow, column), computerColor, PlayerType.Player.Computer));
                    squares[column, thirdRow].Piece = (new RegularPiece(new Location(thirdRow, column), computerColor, PlayerType.Player.Computer));
                    squares[column, seventhRow].Piece = (new RegularPiece(new Location(seventhRow, column), playerColor, PlayerType.Player.User));
                }
            }
        }
    }
}
