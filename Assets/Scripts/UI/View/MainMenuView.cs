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

        private IGameStateService _gameStateService;


        [Inject]
        public void Construct(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        private void Start()
        {

            startButton.OnClickAsObservable()
                .Subscribe(_ => OnStartGame())
                .AddTo(this);

  
            shopButton.OnClickAsObservable()
                .Subscribe(_ => OnOpenShop())
                .AddTo(this);

  
            settingsButton.OnClickAsObservable()
                .Subscribe(_ => OnOpenSettings())
                .AddTo(this);
            _gameStateService.ChangeState(GameStates.Menu);
        }
        
        public void OnStartGame()
        {
            _gameStateService.ChangeState(GameStates.Playing);
        }
        
        public void OnOpenShop()
        {
            // Логика открытия магазина (например, через состояние или панель)
        }

        // Метод для открытия настроек
        public void OnOpenSettings()
        {
            // Логика открытия настроек (например, через панель)
        }
        
        public void ShowMainMenu()
        {
            gameObject.SetActive(true);
        }
        
        public void HideMainMenu()
        {
            gameObject.SetActive(false);
        }
    }
}