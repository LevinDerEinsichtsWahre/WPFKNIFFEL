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
            if (parameter != null)
            {
                Score score = _viewModel.game.CurrentPlayer.Score;
                switch (parameter.ToString())
                {
                    case "one": score.One.IsLocked = !score.One.IsLocked; break;
                    case "two": score.Two.IsLocked = !score.Two.IsLocked; break;
                    case "three": score.Three.IsLocked = !score.Three.IsLocked; break;
                    case "four": score.Four.IsLocked = !score.Four.IsLocked; break;
                    case "five": score.Five.IsLocked = !score.Five.IsLocked; break;
                    case "six": score.Six.IsLocked = !score.Six.IsLocked; break;
                    case "fullHouse": score.FullHouse.IsLocked = !score.FullHouse.IsLocked; break;
                    case "smallStreet": score.SmallStreet.IsLocked = !score.SmallStreet.IsLocked; break;
                    case "bigStreet": score.BigStreet.IsLocked = !score.BigStreet.IsLocked; break;
                    case "threeOfAKind": score.ThreeOfAKind.IsLocked = !score.ThreeOfAKind.IsLocked; break;
                    case "fourOfAKind": score.FourOfAKind.IsLocked = !score.FourOfAKind.IsLocked; break;
                    case "kniffel": score.Kniffel.IsLocked = !score.Kniffel.IsLocked; break;
                    case "chance": score.Chance.IsLocked = !score.Chance.IsLocked; break;

                }
            }
        }
    }
}
