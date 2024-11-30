using System.Collections;
using GameState;
using Services.Input;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Bootstrap
{
    public class GameBootstrapper : MonoBehaviour
    {
        private IGameStateService _gameStateService;

        [Inject]
        public void Construct(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }
        private void Start()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            _gameStateService.ChangeState(GameStates.Menu);
        }
        
    }

}