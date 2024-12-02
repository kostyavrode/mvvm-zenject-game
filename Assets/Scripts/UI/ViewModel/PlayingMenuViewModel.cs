using GameState;

namespace UI.ViewModel
{
    public class PlayingMenuViewModel
    {
        private readonly IGameStateService _gameStateService;

        public PlayingMenuViewModel(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        public void OnPauseGame()
        {
            _gameStateService.ChangeState(GameStates.Pause);
        }

        public void OnGameOver()
        {
            _gameStateService.ChangeState(GameStates.Menu);
        }
    }
}