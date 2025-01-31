using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class Game
    {

        private int maxTurns = 13;
        public List<Player> Players { get; set; }

        public int TurnNumber { get; set; }

        public Player Winner;

        public Game(List<Player> players)
        {
            Players = players;
            TurnNumber = 0;
        }

        public Player? GetWinner()
        {
            Player? winner = null;
            if (TurnNumber == maxTurns)
            {
                if (Players[1].Score.GetCountAll() > Players[0].Score.GetCountAll())
                {
                    winner = Players[1];
                }else
                {
                    winner = Players[0];
                }
            }
            return winner;
        }
    }
}
