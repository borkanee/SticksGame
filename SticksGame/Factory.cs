using System;

namespace SticksGame
{
    public class Factory
    {
        public View GetNewView()
        {
            return new View(new ConsoleWrapper());
        }

        public object GetNewSticks()
        {
            return new Sticks();
        }

        public object GetNewAIPlayer()
        {
            return new AIPlayer();
        }
    }
}