using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.model
{
    public class Dice
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public void Roll(Random random)
        {
            if (!IsLocked)
            {
                Value = random.Next(1, 7);
            }
        }

    }
}
