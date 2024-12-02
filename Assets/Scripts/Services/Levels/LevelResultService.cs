using Interfaces;

namespace Services.Levels
{
    public class LevelResultService : IlevelResultService
    {
        
        private bool _isSuccess;
        private float _completionTime;
        private int _score;
        
        public void SetLevelResult(bool isSuccess, float completionTime, int score)
        {
            _isSuccess = isSuccess;
            _completionTime = completionTime;
            _score = score;
        }
        
        public bool GetLevelSuccess() => _isSuccess;
        
        public float GetCompletionTime() => _completionTime;
        
        public int GetScore() => _score;
    }
}