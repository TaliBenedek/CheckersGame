using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class Square
    {
        public  Location Location { get; }
        public Piece Piece { get; set; }

        public Square(Location location)
        {
            this.Location = location;
        }

        public bool HasPiece()
        {
            return Piece != null;
        }

        public override bool Equals(Object o)
        {
            if (this == o)
            {
                return true;
            }
            if (o == null || this.GetType() != o.GetType())
            {
                return false;
            }
            Square square = (Square)o;
            if (this.Piece == null && square.Piece == null)
            {
                return this.Location.Equals(square.Location);
            }
            if (this.Piece == null || square.Piece == null)
            {
                return false;
            }
            return this.Location.Equals(square.Location)
                    && this.Piece.Equals(square.Piece);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
