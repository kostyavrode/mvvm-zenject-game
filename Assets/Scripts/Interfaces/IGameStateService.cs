using UniRx;

namespace GameState
{
    public interface IGameStateService
    {
        IReadOnlyReactiveProperty<GameStates> CurrentState { get; }
        void ChangeState(GameStates newState);
    }
}