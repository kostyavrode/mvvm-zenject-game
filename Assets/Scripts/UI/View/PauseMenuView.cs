using GameState;
using UI.ViewModel;
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

        private IGameStateService _gameStateService;
        private PauseMenuViewModel _viewModel;
        
        [Inject]
        public void Construct(IGameStateService gameStateService, PauseMenuViewModel viewModel)
        {
            _gameStateService = gameStateService;
            _viewModel = viewModel;
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void Start()
        {
            resumeButton.OnClickAsObservable()
                .Subscribe(_ => ResumeGameButtonClicked())
                .AddTo(this);
            
            mainMenuButton.OnClickAsObservable()
                .Subscribe(_ => MainMenuButtonClicked())
                .AddTo(this);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void ResumeGameButtonClicked()
        {
            _viewModel.OnResumeGame();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void MainMenuButtonClicked()
        {
            _viewModel.OnMainMenu();
        }
    }
}