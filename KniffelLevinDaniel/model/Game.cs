using KniffelLevinDaniel.viemodel;
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

        public Player CurrentPlayer;

        public int leftRolls;

        private Viewmodel viewmodel;

        public Game(List<Player> players ,Viewmodel viewmodel)
        {
            this.viewmodel = viewmodel; 
            Players = players;
            TurnNumber = 0;
            CurrentPlayer = Players[0];
            leftRolls = 3;
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

        public void CheckNextTurn()
        {
            leftRolls--;
            if (leftRolls == 0)
            {
                leftRolls = 3;
                if (CurrentPlayer == viewmodel.PlayerOne)
                {
                    CurrentPlayer = viewmodel.PlayerTwo;
                }
                else
                {
                    CurrentPlayer = viewmodel.PlayerOne;
                }
            }
        }
    }
}
