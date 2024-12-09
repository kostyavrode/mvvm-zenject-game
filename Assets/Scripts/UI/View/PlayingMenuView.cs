using GameState;
using UI.ViewModel;
using UniRx;
using Zenject;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View
{
    public class PlayingMenuView : MonoBehaviour
    {
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button quitButton;


        private PlayingMenuViewModel _viewModel;
        
        [Inject]
        public void Construct(PlayingMenuViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void Start()
        {
 
            pauseButton.OnClickAsObservable()
                .Subscribe(_ => PauseGameButtonClicked())
                .AddTo(this);
 
            quitButton.OnClickAsObservable()
                .Subscribe(_ => GameOverButtonClicked())
                .AddTo(this);
            
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void PauseGameButtonClicked()
        {
            _viewModel.OnPauseGame();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void GameOverButtonClicked()
        {
            _viewModel.OnGameOver();
        }
    }
    }