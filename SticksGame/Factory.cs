using System;

namespace SticksGame
{
    public class Factory
    {
        public View GetNewView()
        {
            return new View(new ConsoleWrapper());
        }
    }
}