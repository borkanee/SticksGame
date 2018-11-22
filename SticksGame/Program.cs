using System;

namespace SticksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View(new ConsoleWrapper());
            Sticks sticks = new Sticks();
            AIPlayer AIPlayer = new AIPlayer();

            Game game = new Game(view, sticks, AIPlayer);

            game.Play();
        }
    }
}
