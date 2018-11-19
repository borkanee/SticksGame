using System;

namespace SticksGame
{
    public class View
    {
        private ConsoleWrapper _console;

        public View(ConsoleWrapper console)
        {
            _console = console;
        }

        public void PresentInstructions()
        {
            _console.WriteLine("Welcome!");
        }
    }
}