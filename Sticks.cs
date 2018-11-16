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

        internal void RemoveSticks(int amount)
        {
            _amount -= amount;
        }
    }
}
