using UniRx;

namespace Services.Settings
{
    public interface ISettingsService
    {
        IReadOnlyReactiveProperty<float> Volume { get; }
        IReadOnlyReactiveProperty<bool> IsVibrate { get; }
        void SetVolume(float value);
        void SetVibrate(bool isVibrate);
        void SaveSettings();
        void LoadSettings();
    }
}