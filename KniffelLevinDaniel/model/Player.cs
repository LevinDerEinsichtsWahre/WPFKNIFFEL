using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.ObjectModel;
using static System.Formats.Asn1.AsnWriter;
namespace KniffelLevinDaniel.model
{
    public class Player
    {
        public ObservableCollection<Dice> Dices { get; set; }
        public Score Score { get; set; }

        private int[] numbers = new int[] { 0, 0, 0, 0, 0, 0 };

        private Viewmodel viewmodel;

        public string PlayerNumber;

        public Player(ObservableCollection<Dice> dices, Viewmodel viewmodel, string playerNumber)
        {
            this.viewmodel = viewmodel;
            this.PlayerNumber = playerNumber;
            this.Dices = dices;
            Score = new Score();
        }

        public void UpdateViewModelText()
        {
            if (PlayerNumber == "Player One")
            {
                viewmodel.onePlayerOne = Score.One.ScoreValue.ToString();
                viewmodel.twoPlayerOne = Score.Two.ScoreValue.ToString();
                viewmodel.threePlayerOne = Score.Three.ScoreValue.ToString();
                viewmodel.fourPlayerOne = Score.Four.ScoreValue.ToString();
                viewmodel.fivePlayerOne = Score.Five.ScoreValue.ToString();
                viewmodel.sixPlayerOne = Score.Six.ScoreValue.ToString();
                viewmodel.bonusPlayerOne = Score.Bonus.ScoreValue.ToString();
                viewmodel.allUpPlayerOne = Score.CountTop.ScoreValue.ToString();
                viewmodel.fullHousePlayerOne = Score.FullHouse.ScoreValue.ToString();
                viewmodel.threeOfAKindPlayerOne = Score.ThreeOfAKind.ScoreValue.ToString();
                viewmodel.fourOfAKindPlayerOne = Score.FourOfAKind.ScoreValue.ToString();
                viewmodel.smallStreetPlayerOne = Score.SmallStreet.ScoreValue.ToString();
                viewmodel.bigStreetPlayerOne = Score.BigStreet.ScoreValue.ToString();
                viewmodel.kniffelPlayerOne = Score.Kniffel.ScoreValue.ToString();
                viewmodel.chancePlayerOne = Score.Chance.ScoreValue.ToString();
                viewmodel.allDownPlayerOne = Score.CountDown.ScoreValue.ToString();
                viewmodel.allPlayerOne = Score.CountAll.ScoreValue.ToString();
            }
            else
            {
                viewmodel.onePlayerTwo = Score.One.ScoreValue.ToString();
                viewmodel.twoPlayerTwo = Score.Two.ScoreValue.ToString();
                viewmodel.threePlayerTwo = Score.Three.ScoreValue.ToString();
                viewmodel.fourPlayerTwo = Score.Four.ScoreValue.ToString();
                viewmodel.fivePlayerTwo = Score.Five.ScoreValue.ToString();
                viewmodel.sixPlayerTwo = Score.Six.ScoreValue.ToString();
                viewmodel.bonusPlayerTwo = Score.Bonus.ScoreValue.ToString();
                viewmodel.allUpPlayerTwo = Score.CountTop.ScoreValue.ToString();
                viewmodel.fullHousePlayerTwo = Score.FullHouse.ScoreValue.ToString();
                viewmodel.threeOfAKindPlayerTwo = Score.ThreeOfAKind.ScoreValue.ToString();
                viewmodel.fourOfAKindPlayerTwo = Score.FourOfAKind.ScoreValue.ToString();
                viewmodel.smallStreetPlayerTwo = Score.SmallStreet.ScoreValue.ToString();
                viewmodel.bigStreetPlayerTwo = Score.BigStreet.ScoreValue.ToString();
                viewmodel.kniffelPlayerTwo = Score.Kniffel.ScoreValue.ToString();
                viewmodel.chancePlayerTwo = Score.Chance.ScoreValue.ToString();
                viewmodel.allDownPlayerTwo = Score.CountDown.ScoreValue.ToString();
                viewmodel.allPlayerTwo = Score.CountAll.ScoreValue.ToString();
            }
            viewmodel.updateTextUi();
        }

        private void checkForNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            foreach (Dice d in Dices)
            {
                switch (d.Value)
                {
                    case 1: numbers[0]++; break;
                    case 2: numbers[1]++; break;
                    case 3: numbers[2]++; break;
                    case 4: numbers[3]++; break;
                    case 5: numbers[4]++; break;
                    case 6: numbers[5]++; break;
                }
            }
            Score.One.ScoreValue = numbers[0];
            Score.Two.ScoreValue = numbers[1] * 2;
            Score.Three.ScoreValue = numbers[2] * 3;
            Score.Four.ScoreValue = numbers[3] * 4;
            Score.Five.ScoreValue = numbers[4] * 5;
            Score.Six.ScoreValue = numbers[5] * 6;
            Score.Chance.ScoreValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Score.Chance.ScoreValue += numbers[i] * (i + 1);
            }
        }

        public void checkForFullHouse()
        {
            bool hasTwo = false;
            bool hasThree = false;
            checkForNumbers();
            foreach (var number in numbers)
            {
                if (number == 2)
                {
                    hasTwo = true;
                }
                else if (number == 3)
                {
                    hasThree = true;
                }
            }
            if (hasTwo == hasThree && hasTwo)
            {
                Score.FullHouse.ScoreValue = 25;
            }
        }

        public void checkForStreet()
        {
            checkForNumbers();
            int hasMinOne = 0;
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    hasMinOne++;
                }
            }
            if (hasMinOne >= 4)
            {
                int isInRow = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        isInRow++;
                    }
                    else if (isInRow <= 3 && !(numbers[i] > 0))
                    {
                        isInRow = 0;
                    }
                    else if (isInRow == 4 && !(numbers[i] > 0))
                    {
                        break;
                    }
                }
                if (isInRow == 4)
                {
                    Score.SmallStreet.ScoreValue = 30;
                }
                else if (isInRow == 5)
                {
                    Score.BigStreet.ScoreValue = 40;
                }
            }
        }

        public void checkForSame()
        {
            checkForNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 3)
                {
                    Score.ThreeOfAKind.ScoreValue = (i + 1) * 3;
                }
                if (numbers[i] >= 4)
                {
                    Score.FourOfAKind.ScoreValue = (i + 1) * 4;
                }
                if (numbers[i] == 5)
                {
                    Score.Kniffel.ScoreValue = 50;
                }
            }
        }
    }
}
