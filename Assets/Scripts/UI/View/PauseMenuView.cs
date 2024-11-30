using GameState;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.View
{
    public class PauseMenuView : MonoBehaviour
    {
        [SerializeField] private Button resumeButton; 
        [SerializeField] private Button mainMenuButton; 
        [SerializeField] private Button quitButton;  

        private IGameStateService _gameStateService;

        
        [Inject]
        public void Construct(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        private void Start()
        {
            resumeButton.OnClickAsObservable()
                .Subscribe(_ => OnResumeGame())
                .AddTo(this);
            
            mainMenuButton.OnClickAsObservable()
                .Subscribe(_ => OnReturnToMainMenu())
                .AddTo(this);
            
            quitButton.OnClickAsObservable()
                .Subscribe(_ => OnQuitGame())
                .AddTo(this);
        }

 
        // ReSharper disable Unity.PerformanceAnalysis
        private void OnResumeGame()
        {

            _gameStateService.ChangeState(GameStates.Playing);
        }


        // ReSharper disable Unity.PerformanceAnalysis
        private void OnReturnToMainMenu()
        {

            _gameStateService.ChangeState(GameStates.Menu);
        }


        private void OnQuitGame()
        {
            Application.Quit();
        }


        public void ShowPauseMenu()
        {
            gameObject.SetActive(true);
        }


        public void HidePauseMenu()
        {
            gameObject.SetActive(false);
        }
    }
}