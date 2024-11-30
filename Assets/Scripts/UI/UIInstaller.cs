using GameState;
using Services;
using System.Collections;
using System.Collections.Generic;
using UI.View;
using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private MainMenuView mainMenuView;
    [SerializeField] private PlayingMenuView playingMenuView;
    [SerializeField] private PauseMenuView pauseMenuView;

    public override void InstallBindings()
    {

        Container.Bind<IUIService>().To<UIService>().AsSingle()
            .WithArguments(mainMenuView, playingMenuView, pauseMenuView);

        Container.Bind<IGameStateService>().To<GameStateService>().AsSingle();
    }
}
