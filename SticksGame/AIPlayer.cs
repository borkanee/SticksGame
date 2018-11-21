using System;

namespace SticksGame
{
    public class AIPlayer
    {
        public void Play(Sticks sticks)
        {
            int amountToRemove = 3;
            if (sticks.Amount == 3) { amountToRemove = 2; }
            else if (sticks.Amount == 2) { amountToRemove = 1; }
            sticks.RemoveSticks(amountToRemove);
        }
    }
}
