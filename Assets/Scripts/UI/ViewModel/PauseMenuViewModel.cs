using GameState;

namespace UI.ViewModel
{
    public class PauseMenuViewModel
    {
        private readonly IGameStateService _gameStateService;

        public PauseMenuViewModel(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        public void OnResumeGame()
        {
            _gameStateService.ChangeState(GameStates.Playing);
        }

        public void OnMainMenu()
        {
            _gameStateService.ChangeState(GameStates.Menu);
        }
    }
}