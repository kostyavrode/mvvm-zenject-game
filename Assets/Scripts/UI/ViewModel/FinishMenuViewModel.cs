using GameState;
using UI.Model;
using UniRx;

namespace UI.ViewModel
{
    public class FinishMenuViewModel
    {
        private readonly IGameStateService _gameStateService;
        private readonly FinishMenuModel _model;
        
        public ReactiveProperty<bool> IsSuccess { get; private set; } = new ReactiveProperty<bool>();
        public ReactiveProperty<float> CompletionTime { get; private set; } = new ReactiveProperty<float>();
        public ReactiveProperty<int> Score { get; private set; } = new ReactiveProperty<int>();

        public FinishMenuViewModel(IGameStateService gameStateService, FinishMenuModel model)
        {
            _gameStateService = gameStateService;
            _model = model;
            
            IsSuccess.Value=_model.IsSuccess;
            CompletionTime.Value=_model.CompletionTime;
            Score.Value=_model.Score;
        }

        public void OnRetry()
        {
            _gameStateService.ChangeState(GameStates.Playing);
        }

        public void OnBackToMenu()
        {
            _gameStateService.ChangeState(GameStates.Menu);
        }
        
        public void SetLevelResult(bool success, float completionTime, int score)
        {
            _model.Update(success, completionTime, score);
            
            IsSuccess.Value = _model.IsSuccess;
            CompletionTime.Value = _model.CompletionTime;
            Score.Value = _model.Score;
        }

    }
}