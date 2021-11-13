using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Location
    {
        public int Row { get; }
        public int Column { get; }

        public Location(int row, int column)
        {
            this.Row = row;
            this.Column = column;
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
            Location location = (Location)o;
            return Row == location.Row && Column == location.Column;
        }

        public override String ToString()
        {
            return "Location{" +
                    "row=" + Row +
                    ", column=" + Column +
                    '}';
        }

        public override int GetHashCode()
        {
            int hashCode = -1663278630;
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Column.GetHashCode();
            return hashCode;
        }
    }
}
