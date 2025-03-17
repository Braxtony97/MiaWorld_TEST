using UnityEngine;

public class GameStateMachine
{
    private IState _loadScene;
    private readonly DIContainer _container;
    private IState _currentState;

    public GameStateMachine(DIContainer container)
    {
        _container = container;
        
        SetState(new LoadSceneState(Enums.Scene.MainMenu, container));
    }
    
    public void SetState(IState newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }
}