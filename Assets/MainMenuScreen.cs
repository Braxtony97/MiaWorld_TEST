using UnityEngine;

public class MainMenuScreen : MonoBehaviour
{
    private DIContainer _diContainer;
    private ILoadLevelService _unityLoadService;


    public void Start()
    {
        _diContainer = SceneContext.DIContainer;
        _unityLoadService = _diContainer.Resolve<ILoadLevelService>("UnityLoadService");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _unityLoadService.Load(Enums.Scene.GameBootstrapper);
        }
    }
}
