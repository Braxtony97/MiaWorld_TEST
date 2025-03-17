using UnityEngine;

public class Game
{
    private GameStateMachine _gameStateMachine;
    private DIContainer _container;
    
    public Game(DIContainer container, MonoBehaviour monoBehaviour)
    {
        _container = container;
        
        _container.Register(new CoroutineService(monoBehaviour));
        _container.Register(new AudioService());
        _container.Register(new SaveLoadService());
        _container.Register<ILoadLevelService>("UnityLoadService", new UnityLoadLevelService(_container));
        
        _gameStateMachine = new GameStateMachine(_container);
        _container.Register(_gameStateMachine);
    }
}
