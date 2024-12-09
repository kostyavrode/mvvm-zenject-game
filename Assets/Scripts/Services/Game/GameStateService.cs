using System.Collections.Generic;
using GameState.States;
using Interfaces;
using Services;
using UniRx;
using UnityEngine;

namespace GameState
{
    public class GameStateService : IGameStateService
    {
        private readonly Dictionary<GameStates, IGameState> _states;
        private readonly ReactiveProperty<GameStates> _currentState = new ReactiveProperty<GameStates>();

        public IReadOnlyReactiveProperty<GameStates> CurrentState => _currentState;

        public GameStateService(IUIService uiService, IlevelResultService levelResultService)
        {
            _states = new Dictionary<GameStates, IGameState>
            {
                { GameStates.Menu, new MenuState(uiService) },
                { GameStates.Playing, new PlayingState(uiService) },
                { GameStates.Pause, new PauseState(uiService) },
                { GameStates.Finish , new FinishedState(uiService, levelResultService)},
                { GameStates.Settings , new SettingsState(uiService)}
            };
        }
    
        public void ChangeState(GameStates newState)
        {
            if (_currentState.Value != null)
                _states[_currentState.Value].Exit();
            Debug.Log("New GameState="+newState.ToString());
            _currentState.Value = newState;
            _states[newState].Enter();
        }
    }
}