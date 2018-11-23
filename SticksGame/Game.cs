using System;

namespace SticksGame
{
    public class Game
    {
        private View _view;
        private Sticks _sticks;
        private AIPlayer _AIPlayer;

        public Game(Factory factory)
        {
            _view = factory.GetNewView();
            _sticks = factory.GetNewSticks();
            _AIPlayer = factory.GetNewAIPlayer();
        }

        public void Play()
        {
            _view.PresentInstructions();

            while (true)
            {
                _sticks.RemoveSticks(_view.GetInput());

                _view.PresentNumberOfSticksLeft(_sticks);

                if (_sticks.Amount <= 0)
                {
                    _view.PresentWinner("AIPlayer");
                    break;
                }

                _view.DisplayAIPlayerAsCurrentPlayer();

                _AIPlayer.Play(_sticks);

                _view.PresentNumberOfSticksLeft(_sticks);

                if (_sticks.Amount <= 0)
                {
                    _view.PresentWinner("Player");
                    break;
                }
            }
        }
    }
}