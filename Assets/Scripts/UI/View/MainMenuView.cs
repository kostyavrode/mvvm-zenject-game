using System;
using GameState;
using UniRx;
using Zenject;
using UnityEngine.UI;
using UnityEngine;

namespace UI.View
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Button shopButton;
        [SerializeField] private Button settingsButton;
        
        private MainMenuViewModel _viewModel;

        [Inject]
        public void Construct(MainMenuViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        private void Start()
        {

            startButton.OnClickAsObservable()
                .Subscribe(_ => StartGameButtonClicked())
                .AddTo(this);

  
            shopButton.OnClickAsObservable()
                .Subscribe(_ => ShopButtonClicked())
                .AddTo(this);

  
            settingsButton.OnClickAsObservable()
                .Subscribe(_ => SettingsButtonClicked())
                .AddTo(this);
        }

        public void StartGameButtonClicked()
        {
            _viewModel.OnStartGame();
        }

        public void SettingsButtonClicked()
        {
            _viewModel.OnSettings();
        }

        public void ShopButtonClicked()
        {
            _viewModel.OnShop();
        }
    }
}