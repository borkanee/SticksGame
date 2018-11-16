using System;

namespace SticksGame
{
    class Sticks
    {
        private int _amount = 21;

        public int Amount 
        {
            get { return _amount; }
        }

        public void RemoveSticks(int amount)
        {
            if (amount > 4 || amount < 1) 
            {
                throw new ArgumentOutOfRangeException("You can only remove 1-4 sticks");
            }
            _amount -= amount;
        }
    }
}
