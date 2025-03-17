using UnityEngine;

public class GameBoostrapper : MonoBehaviour
{
    private static GameBoostrapper _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); 

            var container = new DIContainer();
            var game = new Game(container, this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
