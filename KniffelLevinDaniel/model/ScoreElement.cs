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
                int curretnScoreValue = scoreValue;
                if (!isLocked)
                {
                    scoreValue = value;
                } else
                {
                    scoreValue = curretnScoreValue;
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
            set
            {
                isLocked = value;
            }
        }

        public ScoreElement(int scoreValue)
        {
            ScoreValue = scoreValue;
            isLocked = false;
        }

    }
}
