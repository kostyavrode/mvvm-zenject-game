using Interfaces;
using Services;

namespace GameState.States
{
    public class FinishedState : IGameState
    {
        private readonly IUIService _uiService;
        private readonly IlevelResultService _levelResultService;

        public FinishedState(IUIService uiService, IlevelResultService levelResultService)
        {
            _uiService = uiService;
            _levelResultService = levelResultService;
        }
        public void Enter()
        {
            _uiService.ShowFinishMenu();
            _levelResultService.SetLevelResult(false,0,0);
        }

        public void Exit()
        {
            _uiService.HideFinishMenu();
        }
    }
}