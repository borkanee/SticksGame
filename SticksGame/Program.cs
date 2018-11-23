using System;

namespace SticksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Factory());

            game.Play();
        }
    }
}
