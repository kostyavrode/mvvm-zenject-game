using Services;
using UnityEngine;

namespace GameState.States
{
    public class PlayingState : IGameState
    {
        private readonly IUIService _uiService;

        public PlayingState(IUIService uiService)
        {
            _uiService = uiService;
        }
        public void Enter()
        {
            _uiService.ShowPlayingMenu();
            Time.timeScale = 1f;
        }

        public void Exit()
        {
            _uiService.HidePlayingMenu();
        }
    }
}