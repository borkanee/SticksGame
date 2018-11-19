using System;

namespace SticksGame
{
    public class Sticks
    {
        private int _amount = 21;

        public int Amount 
        {
            get { return _amount; }
        }

        public virtual void RemoveSticks(int amount)
        {
            if (amount > 4 || amount < 1)
            {
                throw new ArgumentOutOfRangeException("You can only remove 1-4 sticks");
            }
            _amount -= amount;
        }
    }
}
