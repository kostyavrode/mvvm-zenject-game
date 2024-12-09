using GameState;
using Services.Settings;
using UniRx;

namespace UI.ViewModel
{
    public class SettingsMenuViewModel
    {
        public ReactiveProperty<float> Volume { get; } = new ReactiveProperty<float>();
        public ReactiveProperty<bool> IsVibrate { get; } = new ReactiveProperty<bool>();
        
        private readonly ISettingsService _settingsService;
        private readonly IGameStateService _gameStateService;

        public SettingsMenuViewModel(ISettingsService settingsService)
        {
            _settingsService = settingsService;

            Volume.Value = _settingsService.Volume.Value;
            IsVibrate.Value = _settingsService.IsVibrate.Value;
            
            _settingsService.Volume.Subscribe(newVolume => Volume.Value = newVolume).AddTo(Disposables);
            _settingsService.IsVibrate.Subscribe(newVibrate => IsVibrate.Value = newVibrate).AddTo(Disposables);
        }

        public void UpdateVolume(float volume)
        {
            _settingsService.SetVolume(volume);
        }

        public void UpdateIsVibrate(bool isVibrate)
        {
            _settingsService.SetVibrate(isVibrate);
        }

        public void SaveSettings()
        {
            _settingsService.SaveSettings();
        }

        public void CloseSettings()
        {
            _gameStateService.ChangeState(GameStates.Menu);
        }
        
        public CompositeDisposable Disposables { get; } = new CompositeDisposable();

        ~SettingsMenuViewModel()
        {
            Disposables.Dispose();
        }
    }
}