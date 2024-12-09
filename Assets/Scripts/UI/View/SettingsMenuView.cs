using UI.ViewModel;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.View
{
    public class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Slider volumeSlider;
        [SerializeField] private Toggle vibrateToggle;
        [SerializeField] private Button saveButton;
        [SerializeField] private Button backButton;
        
        private SettingsMenuViewModel _menuViewModel;
        
        [Inject]
        public void Construct(SettingsMenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
            
            _menuViewModel.Volume.Subscribe(value=>volumeSlider.value = value).AddTo(this);
            _menuViewModel.IsVibrate.Subscribe((bool value) =>vibrateToggle.isOn = value).AddTo(this);
            
            volumeSlider.onValueChanged.AddListener(_menuViewModel.UpdateVolume);
            vibrateToggle.onValueChanged.AddListener(_menuViewModel.UpdateIsVibrate);
            saveButton.onClick.AddListener(_menuViewModel.SaveSettings);
            backButton.onClick.AddListener(() =>Debug.Log("Back to menu"));
        }
    }
}