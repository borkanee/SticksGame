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
            int number = 0;
            bool isInt = false;
            bool validNumber = false;
            while (!(isInt && validNumber))
            {
                isInt = int.TryParse(_console.ReadLine(), out number);
                validNumber = number < 4 && number > 0;
            }
            return number;
        }
    }
}