using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.ObjectModel;
namespace KniffelLevinDaniel.model
{
    public class Player
    {
        public ObservableCollection<Dice> Dices {  get; set; }
        public Score Score { get; set; }

        private int[] numbers = new int[] {0,0,0,0,0,0};

        private Viewmodel viewmodel;

        private string playerNumber;

        public Player(ObservableCollection<Dice> dices, Viewmodel viewmodel, string playerNumber) 
        {
            this.viewmodel = viewmodel;
            this.playerNumber = playerNumber;
            this.Dices = dices;
            Score = new Score();
        }

        public void UpdateViewModelText()
        {
            if (playerNumber == "One")
            {
                viewmodel.onePlayerOne = Score.One.ToString();
                viewmodel.twoPlayerOne = Score.Two.ToString();
                viewmodel.threePlayerOne = Score.Three.ToString();
                viewmodel.fourPlayerOne = Score.Four.ToString();
                viewmodel.fivePlayerOne = Score.Five.ToString();
                viewmodel.sixPlayerOne = Score.Six.ToString();
                viewmodel.bonusPlayerOne = Score.Bonus.ToString();
                viewmodel.allUpPlayerOne = Score.GetCountTop().ToString();
                viewmodel.fullHousePlayerOne = Score.FullHouse.ToString();
                viewmodel.threeOfAKindPlayerOne = Score.ThreeOfAKind.ToString();
                viewmodel.fourOfAKindPlayerOne = Score.FourOfAKind.ToString();
                viewmodel.smallStreetPlayerOne = Score.SmallStreet.ToString();
                viewmodel.bigStreetPlayerOne = Score.BigStreet.ToString();
                viewmodel.kniffelPlayerOne = Score.Kniffel.ToString();
                viewmodel.chancePlayerOne = Score.Chance.ToString();
                viewmodel.allDownPlayerOne = Score.GetCountDown().ToString();
                viewmodel.allPlayerOne = Score.GetCountAll().ToString();
            }
            else
            {
                viewmodel.onePlayerTwo = Score.One.ToString();
                viewmodel.twoPlayerTwo = Score.Two.ToString();
                viewmodel.threePlayerTwo = Score.Three.ToString();
                viewmodel.fourPlayerTwo = Score.Four.ToString();
                viewmodel.fivePlayerTwo = Score.Five.ToString();
                viewmodel.sixPlayerTwo = Score.Six.ToString();
                viewmodel.bonusPlayerTwo = Score.Bonus.ToString();
                viewmodel.allUpPlayerTwo = Score.GetCountTop().ToString();
                viewmodel.fullHousePlayerTwo = Score.FullHouse.ToString();
                viewmodel.threeOfAKindPlayerTwo = Score.ThreeOfAKind.ToString();
                viewmodel.fourOfAKindPlayerTwo = Score.FourOfAKind.ToString();
                viewmodel.smallStreetPlayerTwo = Score.SmallStreet.ToString();
                viewmodel.bigStreetPlayerTwo = Score.BigStreet.ToString();
                viewmodel.kniffelPlayerTwo = Score.Kniffel.ToString();
                viewmodel.chancePlayerTwo = Score.Chance.ToString();
                viewmodel.allDownPlayerTwo = Score.GetCountDown().ToString();
                viewmodel.allPlayerTwo = Score.GetCountAll().ToString();
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
            Score.One = numbers[0];
            Score.Two = numbers[1] * 2;
            Score.Three = numbers[2] * 3;
            Score.Four = numbers[3] * 4;
            Score.Five = numbers[4] * 5;
            Score.Six = numbers[5] * 6;
            Score.Chance = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Score.Chance += numbers[i] * (i + 1);
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
                }else if(number == 3)
                {
                    hasThree = true;
                }
            }
            if (hasTwo == hasThree && hasTwo)
            {
                Score.FullHouse = 25;
            }
        }

        public void checkForStreet(int streetSize)
        {
            checkForNumbers();
            if (streetSize == 4 || streetSize == 5)
            {
                int hasMinOne = 0;
                foreach (var number in numbers)
                {
                    if (number > 0)
                    {
                        hasMinOne++;
                    }
                }
                if (hasMinOne >= streetSize)
                {
                    int isInRow = 1;
                    int lastNumber = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] > 0 && lastNumber > 0)
                        {
                            isInRow++;
                        }
                        else if (isInRow != streetSize && !(numbers[i] > 0 && lastNumber > 0))
                        {
                            isInRow = 0;
                        }
                        lastNumber = numbers[i];
                    }
                    if (isInRow == streetSize && streetSize == 4)
                    {
                        Score.SmallStreet = 30;
                    }else if (isInRow == streetSize && streetSize == 5)
                    {
                        Score.BigStreet = 40;
                    }
                }
            }
        }

        public void checkForSame(int sameSize)
        {
            if (sameSize == 3 || sameSize == 4 || sameSize == 5)
            {
                checkForNumbers();
                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = numbers[i];
                    int sameValue = (i + 1) * number;
                    switch (number)
                    {
                        case 3: Score.ThreeOfAKind = sameValue; break;
                        case 4: Score.FourOfAKind = sameValue; break;
                        case 5: Score.Kniffel = 50; break;
                    } 
                }
            }
        }
    }
}
