using System;
namespace KniffelLevinDaniel.model
{
    public class Player
    {
        public List<Dice> Dices {  get; set; }
        public Score Score { get; set; }

        private int[] numbers = new int[] {0,0,0,0,0,0};

        public Player(List<Dice> dices) 
        {
            this.Dices = dices;
            Score = new Score();
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
                    case 2: numbers[0]++; break;
                    case 3: numbers[0]++; break;
                    case 4: numbers[0]++; break;
                    case 5: numbers[0]++; break;
                    case 6: numbers[0]++; break;
                }
            }
        }

        public int checkForFullHouse()
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
                return 25;
            }
            return 0;
        }

        public int checkForStreet(int streetSize)
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
                if (hasMinOne == streetSize)
                {
                    int isInRow = 0;
                    int lastNumber = 0;
                    for (int i = 0; i > numbers.Length; i++)
                    {
                        if (numbers[i] > 0 && lastNumber > 0)
                        {
                            isInRow++;
                        }
                        else if (isInRow != streetSize)
                        {
                            isInRow = 0;
                        }
                        lastNumber = numbers[i];
                    }
                    if (isInRow == streetSize && streetSize == 4)
                    {
                        return 30;
                    }else if (isInRow == streetSize && streetSize == 5)
                    {
                        return 40;
                    }
                }
            }
            return 0;
        }

        public int checkForSame(int sameSize)
        {
            if (sameSize == 3 || sameSize == 4 || sameSize == 5) 
            checkForNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == sameSize && sameSize != 5)
                {
                    return numbers[i] * (i + 1);
                } else if (numbers[i] == sameSize)
                {
                    return 50;
                }
            }
            return 0;
        }
    }
}
