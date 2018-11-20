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
            _console.WriteLine("Welcome! Enter the number of sticks you want to take (1-3):");
        }

        public int GetInput()
        {
            int numberOfSticks = 0;
            bool isInt = false;
            bool validNumber = false;

            while (!(isInt && validNumber))
            {
                _console.WriteLine("Please enter a valid number of sticks:");
                isInt = int.TryParse(_console.ReadLine(), out numberOfSticks);
                validNumber = numberOfSticks < 4 && numberOfSticks > 0;
            }
            
            return numberOfSticks;
        }

        public void PresentNumberOfSticksLeft(Sticks sticks)
        {
            _console.WriteLine($"There are {sticks.Amount} number of sticks left!");
        }
    }
}