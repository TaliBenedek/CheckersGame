using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class Piece 
    {
        public Location Location { get; set; }
        public PieceColor Color { get; }
        public Player Player { get; }
        bool king;
        public Piece(Location location, PieceColor color, Player player, bool king)
        {
            this.Location = location;
            this.Color = color;
            this.Player = player;
            this.king = king;
        }

        public List<Move> GetMoves()
        {
            List<Move> moves = new List<Move>();
            int currentRow = this.Location.Row;
            int currentCol = this.Location.Column;

            if(Player == Player.User)
            {
                if (king == true)
                {
                    KingMoves(moves, currentRow, currentCol);
                }
                else
                {
                    UserRegularMoves(moves, currentRow, currentCol);
                }                
            }
            else //if computer
            {
                
                if(king == true)
                {
                    KingMoves(moves, currentRow, currentCol);
                }
                else
                {
                    ComputerRegularMoves(moves, currentRow, currentCol);
                }
            }            
            return moves;
        }
        private void UserRegularMoves(List<Move> moves, int currentRow, int currentCol)
        {
            //Possible moves to the upper left
            for (int row = (currentRow) - 1, col = (currentCol) - 1;
                col >= 0 && row >= 0; row--, col--)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }

            //Possible moves to the upper right
            for (int row = (currentRow) - 1, col = (currentCol) + 1;
            col <= 7 && row >= 0; row--, col++)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }
        }

        private void ComputerRegularMoves(List<Move> moves, int currentRow, int currentCol)
        {

            //Possible moves to the lower left
            for (int row = (currentRow) + 1, col = (currentCol) - 1;
                col >= 0 && row <= 7; row++, col--)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }

            //Possible moves to the lower right
            for (int row = (currentRow) + 1, col = (currentCol) + 1;
                col <= 7 && row <= 7; row++, col++)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }
        }

        private void KingMoves(List<Move> moves, int currentRow, int currentCol)
        {
            UserRegularMoves(moves, currentRow, currentCol);
            ComputerRegularMoves(moves, currentRow, currentCol);
        }
    }

}
