using Services;
using UnityEngine;

namespace GameState.States
{
    public class MenuState : IGameState
    {
        private readonly IUIService _uiService;

        public MenuState(IUIService uiService)
        {
            _uiService = uiService;
        }

        public void Enter()
        {
            _uiService.ShowMainMenu();
        }

        public void Exit()
        {
            _uiService.HideMainMenu();
            _uiService.HideMainMenu();
        }
    }
}