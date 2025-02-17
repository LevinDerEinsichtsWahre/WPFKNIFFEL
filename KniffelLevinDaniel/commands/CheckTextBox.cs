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
                if (_viewModel.game.CurrentPlayer == _viewModel.PlayerOne)
                {
                    switch (parameter.ToString())
                    {
                        case "one": _viewModel.onePlayerOneColor = false; break;
                        case "two": _viewModel.twoPlayerOneColor = false; break;
                        case "three": _viewModel.threePlayerOneColor = false; break;
                        case "four": _viewModel.fourPlayerOneColor = false; break;
                        case "five": _viewModel.fivePlayerOneColor = false; break;
                        case "six": _viewModel.sixPlayerOneColor = false; break;
                        case "fullHouse": _viewModel.fullHousePlayerOneColor = false; break;
                        case "smallStreet": _viewModel.smallStreetPlayerOneColor = false; break;
                        case "bigStreet": _viewModel.bigStreetPlayerOneColor = false; break;
                        case "threeOfAKind": _viewModel.threeOfAKindPlayerOneColor = false; break;
                        case "fourOfAKind": _viewModel.fourOfAKindPlayerOneColor = false; break;
                        case "kniffel": _viewModel.kniffelPlayerOneColor = false; break;
                        case "chance": _viewModel.chancePlayerOneColor = false; break;
                    }
                } 
                else
                {

                    switch (parameter.ToString())
                    {
                        case "one": _viewModel.onePlayerTwoColor = false; break;
                        case "two": _viewModel.twoPlayerTwoColor = false; break;
                        case "three": _viewModel.threePlayerTwoColor = false; break;
                        case "four": _viewModel.fourPlayerTwoColor = false; break;
                        case "five": _viewModel.fivePlayerTwoColor = false  ; break;
                        case "six": _viewModel.sixPlayerTwoColor = false    ; break;
                        case "fullHouse": _viewModel.fullHousePlayerTwoColor = false; break;
                        case "smallStreet": _viewModel.smallStreetPlayerTwoColor = false; break;
                        case "bigStreet": _viewModel.bigStreetPlayerTwoColor = false; break;
                        case "threeOfAKind": _viewModel.threeOfAKindPlayerTwoColor = false; break;
                        case "fourOfAKind": _viewModel.fourOfAKindPlayerTwoColor = false; break;
                        case "kniffel": _viewModel.kniffelPlayerTwoColor = false; break;
                        case "chance": _viewModel.chancePlayerTwoColor = false; break;
                    }
                }
                _viewModel.UpdateTextBoxBorder();
                _viewModel.HasCheckBoxLeft = false;
                _viewModel.ButtonText = "Nächster Spieler";
                _viewModel.UpdateButtonText();
                _viewModel.game.CurrentPlayer.UpdateViewModelText();
            }
        }
    }
}
