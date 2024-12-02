namespace Interfaces
{
    public interface IlevelResultService
    {
        void SetLevelResult(bool isSuccess, float completionTime, int score);
        bool GetLevelSuccess();
        float GetCompletionTime();
        int GetScore();
    }
}