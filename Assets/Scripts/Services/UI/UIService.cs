using UI.View;
using UnityEngine;

namespace Services
{
    public class UIService : IUIService
    {
        private readonly MainMenuView _mainMenuView;
        private readonly PauseMenuView _pauseMenuView;
        private readonly PlayingMenuView _playingMenuView;
        private readonly FinishMenuView _finishMenuView;
        private readonly SettingsMenuView _settingsMenuView;

        public UIService(MainMenuView mainMenuView, PauseMenuView pauseMenuView, PlayingMenuView playingMenuView,
            FinishMenuView finishMenuView, SettingsMenuView settingsMenuView)
        {
            _mainMenuView = mainMenuView;
            _pauseMenuView = pauseMenuView;
            _playingMenuView = playingMenuView;
            _finishMenuView = finishMenuView;
            _settingsMenuView = settingsMenuView;
        }

        public void ShowPlayingMenu()
        {
            _playingMenuView.gameObject.SetActive(true);
        }
        public void HidePlayingMenu()
        {
            _playingMenuView.gameObject.SetActive(false);
        }
        public void ShowMainMenu()
        {
            _mainMenuView.gameObject.SetActive(true);
        }

        public void HideMainMenu()
        {
            _mainMenuView.gameObject.SetActive(false);
        }

        public void ShowPauseMenu()
        {
            _pauseMenuView.gameObject.SetActive(true);
        }

        public void HidePauseMenu()
        {
            _pauseMenuView.gameObject.SetActive(false);
        }

        public void ShowFinishMenu()
        {
              _finishMenuView.gameObject.SetActive(true);
        }

        public void HideFinishMenu()
        {
            _finishMenuView.gameObject.SetActive(false);
        }

        public void ShowSettingsMenu()
        {
            _settingsMenuView.gameObject.SetActive(true);
        }

        public void HideSettingsMenu()
        {
            _settingsMenuView.gameObject.SetActive(false);
        }
    }
}