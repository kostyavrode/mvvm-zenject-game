namespace Services
{
    public interface IUIService
    {
        void ShowMainMenu();
        void HideMainMenu();
        void ShowPauseMenu();
        void HidePauseMenu();
        void ShowPlayingMenu();
        void HidePlayingMenu();
        void ShowFinishMenu();
        void HideFinishMenu();
        void ShowSettingsMenu();
        void HideSettingsMenu();
    }
}