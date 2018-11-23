using System;

namespace SticksGame
{
    public class Factory
    {
        public View GetNewView()
        {
            return new View(new ConsoleWrapper());
        }

        public Sticks GetNewSticks()
        {
            return new Sticks();
        }

        public AIPlayer GetNewAIPlayer()
        {
            return new AIPlayer();
        }
    }
}