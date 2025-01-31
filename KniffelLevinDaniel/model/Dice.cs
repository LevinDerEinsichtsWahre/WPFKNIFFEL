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
        Random random = new Random();
        
        public Dice()
        {
            IsLocked = false;
            Roll();
        }

        public int Roll()
        {
            if (!IsLocked)
            {
                Value = random.Next(1, 7);
            }
            return Value;
        }
        public void ToggleLock()
        {
            IsLocked = !IsLocked;
        }
    }
}
