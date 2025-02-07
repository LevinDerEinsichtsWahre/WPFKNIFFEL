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
                    case "one": score.One.IsLocked = true; break;
                    case "two": score.Two.IsLocked = true; break;
                    case "three": score.Three.IsLocked = true; break;
                    case "four": score.Four.IsLocked = true; break;
                    case "five": score.Five.IsLocked = true; break;
                    case "six": score.Six.IsLocked = true; break;
                    case "fullHouse": score.FullHouse.IsLocked = true; break;
                    case "smallStreet": score.SmallStreet.IsLocked = true; break;
                    case "bigStreet": score.BigStreet.IsLocked = true; break;
                    case "threeOfAKind": score.ThreeOfAKind.IsLocked = true; break;
                    case "fourOfAKind": score.FourOfAKind.IsLocked = true; break;
                    case "kniffel": score.Kniffel.IsLocked = true; break;
                    case "chance": score.Chance.IsLocked = true; break;

                }
                _viewModel.HasCheckBoxLeft = false;
                _viewModel.ButtonText = "Nächster Spieler";
            }
        }
    }
}
