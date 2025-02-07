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
                if (!IsLocked)
                {
                    scoreValue = value;
                }
            } 
        }

        public bool IsLocked { get; set; }

        public ScoreElement(int scoreValue)
        {
            ScoreValue = scoreValue;
            IsLocked = false;
        }

    }
}
