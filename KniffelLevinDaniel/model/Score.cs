using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class Score
    {
        public int One 
        { 
            get
            {
                return One;
            }
            set 
            {
                One = value;
            } 
        }
        public int Two 
        {
            get
            {
                return Two;
            }
            set
            {
                Two = value;
            }
        }
        public int Three 
        {
            get
            {
                return Three;
            }
            set
            {
                Three = value;
            }
        }
        public int Four 
        {
            get
            {
                return Four;
            }
            set
            {
                Four = value;
            }
        }
        public int Five 
        {
            get
            {
                return Five;
            }
            set
            {
                Five = value;
            }
        }
        public int Six 
        {
            get
            {
                return Six;
            }
            set
            {
                Six = value;
            }
        }
        public int Bonus 
        {
            get
            {
                int bonus = 0;
                if (getCountTop() > 62)
                {
                    bonus = 35;
                }
                return bonus;
            }
            private set {} 
        }
        public int ThreeOfAKind 
        {
            get
            {
                return ThreeOfAKind;
            }
            set
            {
                ThreeOfAKind = value;
            }
        }
        public int FourOfAKind 
        {
            get
            {
                return FourOfAKind;
            }
            set
            {
                FourOfAKind = value;
            }
        }
        public int FullHouse 
        {
            get
            {
                return FullHouse;
            }
            set
            {
                FullHouse = value;
            }
        }
        public int SmallStreet 
        {
            get
            {
                return SmallStreet;
            }
            set
            {
                SmallStreet = value;
            }
        }
        public int BigStreet 
        {
            get
            {
                return BigStreet;
            }
            set
            {
                BigStreet = value;
            }
        }
        public int Kniffel 
        {
            get
            {
                return Kniffel;
            }
            set
            {
                Kniffel = value;
            }
        }
        public int Chance 
        {
            get
            {
                return Chance;
            }
            set
            {
                Chance = value;
            }
        }

        public int getCountTop()
        {
            return One + Two + Three + Four + Five + Six;
        }

        public int getCountDown()
        {
            return ThreeOfAKind + FourOfAKind + FullHouse + SmallStreet + BigStreet + Kniffel + Chance;
        }

        public int getCountAll()
        {
            return getCountTop() + getCountDown();
        }


        
    }
}
