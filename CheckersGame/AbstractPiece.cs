using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public enum PieceColor
    {
        Red,
        White
    }
    abstract class AbstractPiece
    {
        public Location Location { get; set; } 
        public PieceColor Color { get; } 

    public AbstractPiece(Location location, PieceColor color)
        {
            this.Location = location;
            this.Color = color;
        }

    public override bool Equals(Object o)
        {
            if (this == o)
            {
                return true;
            }
            if (o == null || (this.GetType() != o.GetType()))
            {
                return false;
            }
            AbstractPiece otherPiece = (AbstractPiece)o;
            return this.Location.Equals(otherPiece.Location)
                    && this.Color == otherPiece.Color;
        }

        /**
         * @return a List of all valid moves that this piece can make from this position.
         */
        public abstract ArrayList GetMoves();

        public override int GetHashCode()
        {
            int hashCode = 189311982;
            hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            return hashCode;
        }
    }
}
