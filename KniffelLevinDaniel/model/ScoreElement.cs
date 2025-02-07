using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class ScoreElement
    {

        public int ScoreValue { get; set; }

        public bool IsLocked { get; set; }

        public ScoreElement(int scoreValue)
        {
            ScoreValue = scoreValue;
            IsLocked = false;
        }

    }
}
