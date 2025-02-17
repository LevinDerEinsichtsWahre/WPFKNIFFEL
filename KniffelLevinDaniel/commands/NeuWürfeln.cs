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
            if (_viewModel.ButtonText != "Neues Spiel")
            {
                _viewModel.game.NextReroll();
            }
            _viewModel.PlayerOne.UnLockScoreElements();
            _viewModel.PlayerTwo.UnLockScoreElements();
        }
    }
}
