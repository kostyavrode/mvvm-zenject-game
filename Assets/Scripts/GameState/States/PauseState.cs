using Services;
using UnityEngine;

namespace GameState.States
{
    public class PauseState : IGameState
    {
        private readonly IUIService _uiService;

        public PauseState(IUIService uiService)
        {
            _uiService = uiService;
        }

        public void Enter()
        {
            _uiService.ShowPauseMenu();
            Time.timeScale = 0f; // Останавливаем игру
        }

        public void Exit()
        {
            _uiService.HidePauseMenu();
        }
    }
}