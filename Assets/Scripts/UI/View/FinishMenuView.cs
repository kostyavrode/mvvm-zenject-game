using System;
using UnityEngine.UI;
using UnityEngine;
using UniRx;
using TMPro;
using UI.ViewModel;
using Zenject;

namespace UI.View
{
    public class FinishMenuView : MonoBehaviour
    {
        [SerializeField] private TMP_Text resultText;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text timeText;
        [SerializeField] private Button retryButton;
        [SerializeField] private Button backToMenuButton;
        
        private FinishMenuViewModel _viewModel;

        [Inject]
        public void Construct(FinishMenuViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        private void Start()
        {
            retryButton.OnClickAsObservable()
                .Subscribe(_ => RetryButtonClicked())
                .AddTo(this);
            
            backToMenuButton.OnClickAsObservable()
                .Subscribe(_ => BackToMenuButtonClicked())
                .AddTo(this);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void RetryButtonClicked()
        {
            _viewModel.OnRetry();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void BackToMenuButtonClicked()
        {
            _viewModel.OnBackToMenu();
        }
    }
}