namespace UI.Model
{
    public class FinishMenuModel
    {
        public bool IsSuccess { get; private set; }
        
        public float CompletionTime { get; private set; }
        
        public int Score { get; private set; }
        
        public string LevelName { get; private set; }
        
        public FinishMenuModel(bool isSuccess, float completionTime, int score, string levelName)
        {
            IsSuccess = isSuccess;
            CompletionTime = completionTime;
            Score = score;
            LevelName = levelName;
        }
        
        public void Update(bool isSuccess, float completionTime, int score)
        {
            IsSuccess = isSuccess;
            CompletionTime = completionTime;
            Score = score;
        }
    }
}