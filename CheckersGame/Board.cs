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
                    squares[column, secondRow].Piece = new Piece(new Location(secondRow, column), computerColor, User.Computer, false);
                    squares[column, sixthRow].Piece = new Piece(new Location(sixthRow, column), playerColor, User.Human, false);
                    squares[column, eighthRow].Piece = new Piece(new Location(eighthRow, column), playerColor, User.Human, false);
                }
                else
                {
                    squares[column, firstRow].Piece = new Piece(new Location(firstRow, column), computerColor, User.Computer, false);
                    squares[column, thirdRow].Piece = new Piece(new Location(thirdRow, column), computerColor, User.Computer, false);
                    squares[column, seventhRow].Piece = new Piece(new Location(seventhRow, column), playerColor, User.Human, false);
                }
            }
        }

        public bool IsGameOver()
        {
            int numRed = 0;
            int numWhite = 0;
            for(int i = 0; i < ROWS; i++)
            {
                for(int j = 0; j< COLUMNS; j++)
                {
                    if(squares[i,j].HasPiece())
                    {
                        if(squares[i,j].Piece.Color.Equals(PieceColor.Red))
                        {
                            numRed++;
                        }
                        else
                        {
                            numWhite++;
                        }
                    }
                }
            }
            return numRed == 0 || numWhite == 0;
        }
        //value of board shouldn't change based on current player, but human is min player, comp is max player
        //change algorithm to reflect that 
        public double GetHeuristicValue()
        {
            
            int legalMovesLeft = this.GetLegalMoves(User.Computer).Length + this.GetLegalMoves(User.Human).Length;
            int piecesOnBoard = 0;
            int nrKings = 0;
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (squares[i, j].HasPiece())
                    {
                        piecesOnBoard++; 
                        if (squares[i, j].Piece.King)
                        {
                            nrKings ++; 
                        }
                    }
                }
            }
            //arbitrary calculation, will adjust considerably once it can be tested
            //value needs to be between -1 and 1, so change math
            double value = ((piecesOnBoard + nrKings) * .05) + (1 / legalMovesLeft);
            return value;
        }
        
        public Move[] GetLegalMoves(User currentPlayer) //needs current player
        {
            List<Move> legalMoves = new List<Move>();
            if(currentPlayer.Equals(User.Computer))
            {
                for(int i = 0; i < ROWS; i++)
                {
                    for(int j = 0; j < COLUMNS; j++)
                    {
                        //if there is a piece of the computer on the square
                        if(squares[i, j].HasPiece() && squares[i,j].Piece.Player.Equals(User.Computer))
                        {
                            //check if legal and add to legalMoves
                            List<Move> computerMoves = squares[i,j].Piece.GetMoves();
                            foreach(Move move in computerMoves)
                            {
                                if(IsLegal(move))
                                {
                                    legalMoves.Add(move);
                                }
                            }
                        }
                    }
                }
            }
            else if(currentPlayer.Equals(User.Human))
            {
                for(int i = 0; i < ROWS; i++)
                {
                    for(int j = 0; j < COLUMNS; j++)
                    {
                        if(squares[i, j].HasPiece() && squares[i,j].Piece.Player.Equals(User.Human))
                        {
                            List<Move> userMoves = squares[i,j].Piece.GetMoves();
                            foreach(Move move in userMoves)
                            {
                                if(IsLegal(move))
                                {
                                    legalMoves.Add(move);
                                }
                            }
                        }
                    }
                }
            }
            Move[] legalMovesArray = legalMoves.ToArray();
            return legalMovesArray;
        }

        public bool IsLegal(Move move) 
        {
            //check if destination of move is empty
            if(squares[move.To.Row,move.To.Column].HasPiece())
            {
                return false;
            }
            return true;
        }

        public Board PlayMove(Move move)
        {
            Board newBoard = CopyBoard();
                Location origin = move.From;
                Location destination = move.To;
                Square currentSquare = newBoard.GetSquare(origin);
                Square destinationSquare = newBoard.GetSquare(destination);
                Piece currentPiece = currentSquare.Piece;

                currentSquare.Piece = null;
                currentPiece.Location = destination;
                destinationSquare.Piece = currentPiece;
            return newBoard;
        }

        private Square GetSquare(Location location)
        {
            return squares[location.Column, location.Row];
        }

        private Board CopyBoard()
        {
            Board copy = new Board();
            for (int column = 0; column < squares.Length; column++)
            {
                for (int row = 0; row < squares.Length; row++)
                {
                    Square thisSquare = squares[column, row];
                    Piece thisPiece = thisSquare.Piece;

                    Square copySquare = copy.squares[column, row];
                    Piece copyPiece = thisPiece == null ? null : thisPiece.Copy();
                    copySquare.Piece = copyPiece;
                }
            }
            return copy;
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
            Move[] potentialMoves = GetLegalMoves(User.Computer);
            for (int index = 0; index < potentialMoves.Length; index++)
            {
                Board newBoard = this.PlayMove(potentialMoves[0]);
                double boardValue = AlphaBeta.GetAlphaBetaValue(this, depth, alpha, beta, User.Computer);
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
