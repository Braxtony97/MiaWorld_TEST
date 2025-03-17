using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnityLoadLevelService : ILoadLevelService
{
    private DIContainer _container;
    private CoroutineService _coroutineService;
    public UnityLoadLevelService(DIContainer container)
    {
        _container = container;
        _coroutineService = _container.Resolve<CoroutineService>();
    }
    
    public void Load(Enums.Scene scene)
    {
        if (SceneManager.GetActiveScene().name != scene.ToString())
        {
            _coroutineService.StartCoroutine(LoadSceneCoroutine(scene));
        }
    }

    private IEnumerator LoadSceneCoroutine(Enums.Scene scene)
    {
        var asyncLoad = SceneManager.LoadSceneAsync(scene.ToString());

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
