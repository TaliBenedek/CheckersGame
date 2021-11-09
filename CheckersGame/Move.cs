using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class Move
    {
        public Location From { get; }
        public Location To { get; }

        public Move(Location from, Location to)
        {
            this.From = from;
            this.To = to;
        }
    }
}
