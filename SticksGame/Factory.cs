using System;

namespace SticksGame
{
    public class Factory
    {
        public virtual View GetNewView()
        {
            return new View(new ConsoleWrapper());
        }

        public virtual Sticks GetNewSticks()
        {
            return new Sticks();
        }

        public virtual AIPlayer GetNewAIPlayer()
        {
            return new AIPlayer();
        }
    }
}