using System;

namespace SticksGame
{
    class Sticks
    {
        private int _numberOfSticks = 21;

        public int NumberOfSticks 
        {
            get { return _numberOfSticks; }
        }

        internal void RemoveSticks(int amount)
        {
            _numberOfSticks -= amount;
        }
    }
}
