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
            _levelResultService.SetLevelResult(_levelResultService.GetLevelSuccess()
                ,_levelResultService.GetCompletionTime(),_levelResultService.GetScore());
        }

        public void Exit()
        {
            _uiService.HideFinishMenu();
        }
    }
}