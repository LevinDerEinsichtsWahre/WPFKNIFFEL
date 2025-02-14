using KniffelLevinDaniel.model;
using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.commands
{
    internal class CheckTextBox : Command
    {
        private readonly Viewmodel _viewModel;

        public CheckTextBox(Viewmodel viewModel) : base(viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null && _viewModel.HasCheckBoxLeft)
            {
                Score score = _viewModel.game.CurrentPlayer.Score;
                switch (parameter.ToString())
                {
                    case "one": score.One.LockElement(); break;
                    case "two": score.Two.LockElement(); break;
                    case "three": score.Three.LockElement(); break;
                    case "four": score.Four.LockElement(); break;
                    case "five": score.Five.LockElement(); break;
                    case "six": score.Six.LockElement(); break;
                    case "fullHouse": score.FullHouse.LockElement(); break;
                    case "smallStreet": score.SmallStreet.LockElement(); break;
                    case "bigStreet": score.BigStreet.LockElement(); break;
                    case "threeOfAKind": score.ThreeOfAKind.LockElement(); break;
                    case "fourOfAKind": score.FourOfAKind.LockElement(); break;
                    case "kniffel": score.Kniffel.LockElement(); break;
                    case "chance": score.Chance.LockElement(); break;

                }
                _viewModel.HasCheckBoxLeft = false;
                _viewModel.ButtonText = "Nächster Spieler";
                _viewModel.UpdateButtonText();
            }
        }
    }
}
