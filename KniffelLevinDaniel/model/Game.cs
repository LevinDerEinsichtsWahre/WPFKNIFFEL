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
            leftRolls = 4;
        }

        public Player? GetWinner()
        {
            Player? winner = null;
            if (TurnNumber == maxTurns)
            {
                if (Players[1].Score.CountAll.ScoreValue > Players[0].Score.CountAll.ScoreValue)
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
            if (leftRolls == 1)
            {
                if (viewmodel.HasCheckBoxLeft == true)
                {
                    viewmodel.ButtonReroll = false;
                }
                viewmodel.ButtonText = "Nächster Spieler";
            } else
            {
                viewmodel.ButtonText = "Neu Würfeln";
            }
            viewmodel.UpdateButtonText();
            if (leftRolls == 0 || viewmodel.HasCheckBoxLeft == false)
            {
                viewmodel.HasCheckBoxLeft = true;
                leftRolls = 4;
                viewmodel.game.CurrentPlayer.Score.ResetUnmarkedScoreElements();
                CurrentPlayer.UpdateViewModelText();
                if (CurrentPlayer == viewmodel.PlayerOne)
                {
                    CurrentPlayer = viewmodel.PlayerTwo;
                    viewmodel.currentPlayer = CurrentPlayer.PlayerNumber;
                }
                else
                {
                    CurrentPlayer = viewmodel.PlayerOne;
                    viewmodel.currentPlayer = CurrentPlayer.PlayerNumber;
                }
                foreach (var dice in viewmodel.Dices)
                {
                    dice.IsLocked = false;
                    viewmodel.UpdateDiceColor();
                }
                viewmodel.UpdateCurrentPlayer();
                NextReroll();
            }
        }

        public void NextReroll()
        {
            if (!(leftRolls <= 1 && viewmodel.HasCheckBoxLeft))
            {
                if (viewmodel.HasCheckBoxLeft)
                {
                    foreach (var dice in viewmodel.Dices)
                    {
                        dice.ResetValue();
                    }
                    viewmodel.UpdateDiceValues();
                    Task.Delay(200).ContinueWith(_ =>
                    {
                        foreach (var dice in viewmodel.Dices)
                        {
                            dice.Roll();
                        }
                        CurrentPlayer.checkForStreet();
                        CurrentPlayer.checkForSame();
                        CurrentPlayer.checkForFullHouse();
                        CurrentPlayer.UpdateViewModelText();
                        viewmodel.UpdateDiceValues();

                    }
                    );
                }
                CheckNextTurn();
            }
        }

        public bool checkForEnd()
        {
            if (viewmodel.PlayerOne.CheckForUnlockedScore() && viewmodel.PlayerTwo.CheckForUnlockedScore())
            {
                return true;
            }
            return false;
        }

    }
}
