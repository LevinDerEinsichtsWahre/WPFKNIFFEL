using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class ScoreElement
    {
        private int scoreValue;
        public int ScoreValue
        {
            get
            {
                return scoreValue;
            }
            set
            {
                if (!isLocked)
                {
                    scoreValue = value;
                }
            }
        }

        private bool isLocked;
        public bool IsLocked
        {
            get
            {
                return isLocked;
            }
            private set
            {
                isLocked = value;
            }
        }

        public ScoreElement(int scoreValue)
        {
            this.scoreValue = scoreValue;
            isLocked = false;
        }

        public void LockElement()
        {
            this.isLocked = true;
        }
    }
}
