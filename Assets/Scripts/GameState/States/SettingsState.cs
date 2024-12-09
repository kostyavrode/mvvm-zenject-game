using Services;

namespace GameState.States
{
    public class SettingsState : IGameState
    {
        private readonly IUIService _uiService;

        public SettingsState(IUIService uiService)
        {
            _uiService = uiService;
        }
        public void Enter()
        {
            _uiService.ShowSettingsMenu();
        }

        public void Exit()
        {
            _uiService.HideSettingsMenu();
        }
    }
}