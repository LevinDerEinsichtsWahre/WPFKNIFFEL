using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    class ScoreElement
    {

        public int ScoreValue { get; private set; }

        public bool IsLocked { get; set; }

        public ScoreElement(int scoreValue)
        {
            ScoreValue = scoreValue;
            IsLocked = false;
        }

    }
}
