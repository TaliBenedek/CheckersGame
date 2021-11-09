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

        public void SetUpBoard()
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                int rowWhite = 1;
                int rowBlack = 6;
                squares[column, rowWhite].Piece = (new RegularPiece(new Location(rowWhite, column), PieceColor.White));
                squares[column, rowBlack].Piece = (new RegularPiece(new Location(rowBlack, column), PieceColor.Red));
            }
        }
    }
}
