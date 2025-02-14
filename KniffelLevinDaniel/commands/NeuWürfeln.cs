using KniffelLevinDaniel.model;
using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.commands
{
    internal class NeuWürfeln : Command
    {
        private readonly Viewmodel _viewModel;

        public NeuWürfeln(Viewmodel viewModel) : base(viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (!(_viewModel.game.leftRolls < 2 && _viewModel.HasCheckBoxLeft))
            {
                if (_viewModel.HasCheckBoxLeft)
                {
                    foreach (var dice in viewModel.Dices)
                    {
                        dice.Roll();
                    }
                    _viewModel.game.CurrentPlayer.checkForStreet();
                    _viewModel.game.CurrentPlayer.checkForSame();
                    _viewModel.game.CurrentPlayer.checkForFullHouse();
                    _viewModel.game.CurrentPlayer.UpdateViewModelText();
                    _viewModel.UpdateDiceValues();
                }
                _viewModel.game.CheckNextTurn();
            }
            else
            {
                _viewModel.ButtonText = "Nächster Spieler";
            }
        }
    }
}
