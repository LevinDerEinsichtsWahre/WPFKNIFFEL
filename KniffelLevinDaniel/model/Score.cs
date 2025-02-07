using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class Score
    {
        private int one;
        public int One
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

        private int two;
        public int Two
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

        private int three;
        public int Three
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

        private int four;
        public int Four
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

        private int five;
        public int Five
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
        private int six;
        public int Six
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
        private int bonus = 0;
        public int Bonus
        {
            get
            {
                if (GetCountTop() > 62)
                {
                    bonus = 35;
                }
                return bonus;
            }
            private set { bonus = value; }
        }
        private int threeOfAKind;
        public int ThreeOfAKind
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
        private int fourOfAKind;
        public int FourOfAKind
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
        private int fullHouse;
        public int FullHouse
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
        private int smallStreet;
        public int SmallStreet
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
        private int bigStreet;
        public int BigStreet
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
        private int kniffel;
        public int Kniffel
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
        private int chance;
        public int Chance
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

        public int GetCountTop()
        {
            return One + Two + Three + Four + Five + Six;
        }

        public int GetCountDown()
        {
            return ThreeOfAKind + FourOfAKind + FullHouse + SmallStreet + BigStreet + Kniffel + Chance;
        }

        public int GetCountAll()
        {
            return GetCountTop() + GetCountDown();
        }

    }
}
