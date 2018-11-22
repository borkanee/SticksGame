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

        public virtual void PresentInstructions()
        {
            _console.WriteLine("Welcome! Enter the number of sticks you want to take (1-3):");
        }

        public virtual int GetInput()
        {
            int numberOfSticks = 0;
            bool isInt = int.TryParse(_console.ReadLine(), out numberOfSticks);
            bool validNumber = numberOfSticks < 4 && numberOfSticks > 0;

            while (!(isInt && validNumber))
            {
                _console.WriteLine("Please enter a valid number of sticks:");
                isInt = int.TryParse(_console.ReadLine(), out numberOfSticks);
                validNumber = numberOfSticks < 4 && numberOfSticks > 0;
            }

            return numberOfSticks;
        }

        public virtual void PresentNumberOfSticksLeft(Sticks sticks)
        {
            _console.WriteLine($"There are {sticks.Amount} number of sticks left!");
        }

        public virtual void PresentWinner(string winner)
        {
            _console.WriteLine($"{winner} won the game!");
        }

        public void DisplayAIPlayerAsCurrentPlayer()
        {
             _console.WriteLine("AI plays...");
        }
    }
}