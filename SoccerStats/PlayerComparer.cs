using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            
            return y.PointsPerGame.CompareTo(x.PointsPerGame);

        }
    }
}
