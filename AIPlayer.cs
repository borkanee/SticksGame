using System;
using Moq;

namespace SticksGame
{
    class AIPlayer
    {
        internal void Play(Sticks sticks)
        {
            sticks.RemoveSticks(3);
        }
    }
}
