using System;

namespace SticksGame
{
    public class Game
    {
        private View _view;
        private Sticks _sticks;
        private AIPlayer _AIPlayer;

        public Game(View view, Sticks sticks, AIPlayer AIPlayer)
        {
            _view = view;
            _sticks = sticks;
            _AIPlayer = AIPlayer;
        }

        public void Play()
        {
            _view.PresentInstructions();

            int playerInput = _view.GetInput();
            _sticks.RemoveSticks(playerInput);

            _view.PresentWinner("AIPlayer");
        }
    }
}