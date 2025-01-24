using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    internal class Game
    {
        public List<Player> Players { get; set; }

        public int TurnNumber { get; set; }

        public Game(List<Player> players)
        {
            Players = players;
            TurnNumber = 0;
        }
    }
}
