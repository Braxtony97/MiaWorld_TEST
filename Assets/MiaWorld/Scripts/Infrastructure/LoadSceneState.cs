using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneState : IState
{
    private ILoadLevelService _loadLevelService;

    private static readonly Dictionary<Enums.Scene, string> SceneNames = new ()
    {
        { Enums.Scene.GameBootstrapper, "GameBootstrapper" },
        { Enums.Scene.MainMenu, "MainMenu"},
        { Enums.Scene.PlayMode, "PlayMode"}
    };
    
    public LoadSceneState(Enums.Scene scene, DIContainer container)
    {
        _loadLevelService = container.Resolve<ILoadLevelService>("UnityLoadService"); 
    }
    
    public void Enter()
    {
        _loadLevelService.Load(Enums.Scene.MainMenu);
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }
}