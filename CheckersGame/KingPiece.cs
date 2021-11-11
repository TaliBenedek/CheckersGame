using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class KingPiece : AbstractPiece
    {
        public KingPiece(Location location, Color color, PlayerType.Player player) : base(location, color, player)
        {
        }

        public override ArrayList GetMoves()
        {
            ArrayList moves = new ArrayList();
            int currentRow = this.Location.Row;
            int currentCol = this.Location.Column;

            //Possible moves to the upper left
            for (int row = (currentRow) - 1, col = (currentCol) - 1;
                col >= 0 && row >= 0; row--, col--)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }

            //Possible moves to the lower left
            for (int row = (currentRow) + 1, col = (currentCol) - 1;
                col >= 0 && row <= 7; row++, col--)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }

            //Possible moves to the upper right
            for (int row = (currentRow) - 1, col = (currentCol) + 1;
                col <= 7 && row >= 0; row--, col++)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }

            //Possible moves to the lower right
            for (int row = (currentRow) + 1, col = (currentCol) + 1;
                col <= 7 && row <= 7; row++, col++)
            {
                moves.Add(new Move(this.Location, new Location(row, col)));
            }
            return moves;
        }
    }
}
