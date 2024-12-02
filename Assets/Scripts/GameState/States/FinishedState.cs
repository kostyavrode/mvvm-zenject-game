using Services;

namespace GameState.States
{
    public class FinishedState : IGameState
    {
        private readonly IUIService _uiService;

        public FinishedState(IUIService uiService)
        {
            _uiService = uiService;
        }
        public void Enter()
        {
            _uiService.ShowFinishMenu();
            
        }

        public void Exit()
        {
            _uiService.HideFinishMenu();
        }
    }
}