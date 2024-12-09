using UniRx;
using UnityEngine;

namespace Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private readonly ReactiveProperty<float> _volume = new ReactiveProperty<float>(1.0f);
        private readonly ReactiveProperty<bool> _isVibrate= new ReactiveProperty<bool>(false);
        
        public IReadOnlyReactiveProperty<float> Volume => _volume;
        public IReadOnlyReactiveProperty<bool> IsVibrate => _isVibrate;
        
        public void SetVolume(float value)
        {
            _volume.Value = Mathf.Clamp01(value);
        }

        public void SetVibrate(bool isVibrate)
        {
            _isVibrate.Value = isVibrate;
        }

        public void SaveSettings()
        {
            PlayerPrefs.SetFloat("Volume", _volume.Value);
            PlayerPrefs.SetInt("IsVibrate", _isVibrate.Value ? 1 : 0);
            PlayerPrefs.Save();
        }

        public void LoadSettings()
        {
            _volume.Value = PlayerPrefs.GetFloat("Volume", 1.0f);
            _isVibrate.Value = PlayerPrefs.GetInt("IsVibrate", 1) == 1;
        }
    }
}