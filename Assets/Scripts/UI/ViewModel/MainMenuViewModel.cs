using GameState;
    public class MainMenuViewModel
    {
        private readonly IGameStateService _gameStateService;

        public MainMenuViewModel(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void OnStartGame()
        {
            _gameStateService.ChangeState(GameStates.Playing);
        }

        public void OnSettings()
        {
            _gameStateService.ChangeState(GameStates.Settings);
        }

        public void OnShop()
        {
            // Логика для перехода в магазин
        }
    }
