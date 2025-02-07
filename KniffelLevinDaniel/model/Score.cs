using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class Score
    {
        private ScoreElement one;
        public ScoreElement One
        {
            get
            {
                return one;
            }
            set
            {
                one = value;
            }
        }

        private ScoreElement two;
        public ScoreElement Two
        {
            get
            {
                return two;
            }
            set
            {
                two = value;
            }
        }

        private ScoreElement three;
        public ScoreElement Three
        {
            get
            {
                return three;
            }
            set
            {
                three = value;
            }
        }

        private ScoreElement four;
        public ScoreElement Four
        {
            get
            {
                return four;
            }
            set
            {
                four = value;
            }
        }

        private ScoreElement five;
        public ScoreElement Five
        {
            get
            {
                return five;
            }
            set
            {
                five = value;
            }
        }
        private ScoreElement six;
        public ScoreElement Six
        {
            get
            {
                return six;
            }
            set
            {
                six = value;
            }
        }
        private ScoreElement bonus;
        public ScoreElement Bonus
        {
            get
            {
                if (GetCountTop() > 62)
                {
                    bonus.ScoreValue = 35;
                }
                return bonus;
            }
            private set { bonus = value; }
        }
        private ScoreElement threeOfAKind;
        public ScoreElement ThreeOfAKind
        {
            get
            {
                return threeOfAKind;
            }
            set
            {
                threeOfAKind = value;
            }
        }
        private ScoreElement fourOfAKind;
        public ScoreElement FourOfAKind
        {
            get
            {
                return fourOfAKind;
            }
            set
            {
                fourOfAKind = value;
            }
        }
        private ScoreElement fullHouse;
        public ScoreElement FullHouse
        {
            get
            {
                return fullHouse;
            }
            set
            {
                fullHouse = value;
            }
        }
        private ScoreElement smallStreet;
        public ScoreElement SmallStreet
        {
            get
            {
                return smallStreet;
            }
            set
            {
                smallStreet = value;
            }
        }
        private ScoreElement bigStreet;
        public ScoreElement BigStreet
        {
            get
            {
                return bigStreet;
            }
            set
            {
                bigStreet = value;
            }
        }
        private ScoreElement kniffel;
        public ScoreElement Kniffel
        {
            get
            {
                return kniffel;
            }
            set
            {
                kniffel = value;
            }
        }
        private ScoreElement chance;
        public ScoreElement Chance
        {
            get
            {
                return chance;
            }
            set
            {
                chance = value;
            }
        }
        private ScoreElement countTop;
        public ScoreElement CountTop
        {
            get
            {
                countTop.ScoreValue = GetCountTop();
                return countTop;
            }
            set
            {
                countTop = value;
            }
        }
        private ScoreElement countDown;
        public ScoreElement CountDown
        {
            get
            {
                countDown.ScoreValue = GetCountDown();
                return countDown;
            }
            set
            {
                countDown = value;
            }
        }
        private ScoreElement countAll;
        public ScoreElement CountAll
        {
            get
            {
                countAll.ScoreValue = GetCountAll();
                return countAll;
            }
            set
            {
                countAll = value;
            }
        }

        private int GetCountTop()
        {
            return One.ScoreValue + Two.ScoreValue + Three.ScoreValue + Four.ScoreValue + Five.ScoreValue + Six.ScoreValue;
        }

        private int GetCountDown()
        {
            return ThreeOfAKind.ScoreValue + FourOfAKind.ScoreValue + FullHouse.ScoreValue + SmallStreet.ScoreValue + BigStreet.ScoreValue + Kniffel.ScoreValue + Chance.ScoreValue;
        }

        private int GetCountAll()
        {
            return GetCountTop() + GetCountDown();
        }

        public Score()
        {
            one = new ScoreElement(0);
            two = new ScoreElement(0);
            three = new ScoreElement(0);
            four = new ScoreElement(0);
            five = new ScoreElement(0);
            six = new ScoreElement(0);
            bonus = new ScoreElement(0);
            threeOfAKind = new ScoreElement(0);
            fourOfAKind = new ScoreElement(0);
            fullHouse = new ScoreElement(0);
            smallStreet = new ScoreElement(0);
            bigStreet = new ScoreElement(0);
            kniffel = new ScoreElement(0);
            chance = new ScoreElement(0);
            countDown = new ScoreElement(0);
            countTop = new ScoreElement(0);
            countAll = new ScoreElement(0);
        }

    }
}
