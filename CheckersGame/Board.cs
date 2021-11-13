using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Board
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

        public void SetUpBoard(PieceColor computerColor, PieceColor playerColor)
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
                    squares[column, secondRow].Piece = new Piece(new Location(secondRow, column), computerColor, Player.Computer, false);
                    squares[column, sixthRow].Piece = new Piece(new Location(sixthRow, column), playerColor, Player.User, false);
                    squares[column, eighthRow].Piece = new Piece(new Location(eighthRow, column), playerColor, Player.User, false);
                }
                else
                {
                    squares[column, firstRow].Piece = new Piece(new Location(firstRow, column), computerColor, Player.Computer, false);
                    squares[column, thirdRow].Piece = new Piece(new Location(thirdRow, column), computerColor, Player.Computer, false);
                    squares[column, seventhRow].Piece = new Piece(new Location(seventhRow, column), playerColor, Player.User, false);
                }
            }
        }

        public bool IsGameOver()
        {
            /*
             * TO DO
             * return true or false if game is over at current position
             * 
             * 
             */

            return false;
        }

        public double GetHeuristicValue()
        {
            /*
             * TO DO
             * evaluate current board
             * (number of pieces left, weight kings>pawns, number of legal moves left
             */
            return 0.0;
        }
        //do we have a move class? or just acess through x,y coordinates?
        public Move[] GetLegalMoves(Player currentPlayer) //needs current board and player
        {
            return null;
        }

        public Board PlayMove(Move potentialMove)
        {
            /*
             * TO DO
             * play provided move
             * return new board 
             */
            return null;
        }

        public Move GetComputersMove() 
            //pass current player? current player should be a field in this class, updated throughout the game
            // same idea for current board?
        {
            int depth = 3; //TO DO: set based on difficulty level
            double alpha = -1;
            double beta = 1;
            double highestValue = -1; //?
            Move bestMove = null;
            Move[] potentialMoves = GetLegalMoves(currentPlayer);
            for (int index = 0; index < potentialMoves.Length; index++)
            {
                Board newBoard = currentBoard.PlayMove(potentialMoves[0]);
                double boardValue = AlphaBeta.GetAlphaBetaValue(currentBoard, depth, alpha, beta, currentPlayer);
                //double boardValue = newBoard.GetAlphaBetaValue();
                if (boardValue > highestValue)
                {
                    bestMove = potentialMoves[index];
                    highestValue = boardValue;
                }

            }
            return bestMove;
        }

    }
}
