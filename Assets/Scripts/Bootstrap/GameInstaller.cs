using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using GameState;
using Services;
using Services.Input;
using UI.View;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    // Ссылки на UI элементы
    public MainMenuView mainMenuView;
    public PauseMenuView pauseMenuView;
    public PlayingMenuView playingMenuView;

    public override void InstallBindings()
    {
        // Биндим UI компоненты
        Container.Bind<MainMenuView>().FromInstance(mainMenuView).AsSingle();
        Container.Bind<PauseMenuView>().FromInstance(pauseMenuView).AsSingle();
        Container.Bind<PlayingMenuView>().FromInstance(playingMenuView).AsSingle();

        // Биндим сервисы
        Container.Bind<IGameStateService>().To<GameStateService>().AsSingle();
        Container.Bind<IUIService>().To<UIService>().AsSingle()
            .WithArguments(mainMenuView, pauseMenuView, playingMenuView);

        // (Дополнительно) Биндим InputService
        Container.Bind<IInputService>().To<InputService>().AsSingle();
    }
}
