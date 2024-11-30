using GameState;
using UniRx;
using Zenject;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View
{
    public class PlayingMenuView : MonoBehaviour
    {
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button saveButton;
        [SerializeField] private Button quitButton;

        private IGameStateService _gameStateService;
        
        [Inject]
        public void Construct(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        private void Start()
        {
 
            pauseButton.OnClickAsObservable()
                .Subscribe(_ => OnPauseGame())
                .AddTo(this);


            saveButton.OnClickAsObservable()
                .Subscribe(_ => OnSaveGame())
                .AddTo(this);

 
            quitButton.OnClickAsObservable()
                .Subscribe(_ => OnReturnToMainMenu())
                .AddTo(this);
            
        }

        // Метод для паузы игры
        private void OnPauseGame()
        {
            _gameStateService.ChangeState(GameStates.Pause);  // Переводим игру в состояние паузы
        }

        // Метод для сохранения игры
        private void OnSaveGame()
        {
            // Логика сохранения игры
        }

        // Метод для выхода в главное меню
        private void OnReturnToMainMenu()
        {
            _gameStateService.ChangeState(GameStates.Menu);  // Переход в главное меню
        }

        // Метод для отображения меню в процессе игры
        public void ShowPlayingMenu()
        {
            gameObject.SetActive(true);
        }

        // Метод для скрытия меню в процессе игры
        public void HidePlayingMenu()
        {
            gameObject.SetActive(false);
        }
    }
    }