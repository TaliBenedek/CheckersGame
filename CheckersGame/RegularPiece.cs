using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class RegularPiece : AbstractPiece
    {
        public RegularPiece(Location location, PieceColor color) : base(location, color)
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
            return moves;
        }
    }
}
