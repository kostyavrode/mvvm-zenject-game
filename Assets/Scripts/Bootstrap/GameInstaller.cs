using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using GameState;
using Interfaces;
using Services;
using Services.Input;
using Services.Levels;
using Services.Settings;
using UI.Model;
using UI.View;
using UI.ViewModel;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{

    public MainMenuView mainMenuView;
    public PauseMenuView pauseMenuView;
    public PlayingMenuView playingMenuView;
    public FinishMenuView finishMenuView;
    public SettingsMenuView settingsMenuView;

    public override void InstallBindings()
    {
        BindUI();
        BindServices();
    }

    private void BindUI()
    {

        Container.Bind<MainMenuView>().FromInstance(mainMenuView).AsSingle();
        Container.Bind<PauseMenuView>().FromInstance(pauseMenuView).AsSingle();
        Container.Bind<PlayingMenuView>().FromInstance(playingMenuView).AsSingle();
        Container.Bind<SettingsMenuView>().FromInstance(settingsMenuView).AsSingle();
        Container.Bind<FinishMenuView>().FromInstance(finishMenuView).AsSingle();
        
        Container.Bind<MainMenuViewModel>().AsSingle();
        Container.Bind<PauseMenuViewModel>().AsSingle();
        Container.Bind<PlayingMenuViewModel>().AsSingle();
        Container.Bind<SettingsMenuViewModel>().AsSingle();
        Container.Bind<FinishMenuViewModel>().AsSingle();
        
        Container.Bind<FinishMenuModel>().AsSingle().WithArguments(false,0f,0,"empty");
    }

    private void BindServices()
    {
        Container.Bind<IGameStateService>().To<GameStateService>().AsSingle();
        Container.Bind<IUIService>().To<UIService>().AsSingle()
            .WithArguments(mainMenuView, pauseMenuView, playingMenuView);
        Container.Bind<IInputService>().To<InputService>().AsSingle();
        Container.Bind<IlevelResultService>().To<LevelResultService>().AsSingle();
        Container.Bind<ISettingsService>().To<SettingsService>().AsSingle();
    }
}
