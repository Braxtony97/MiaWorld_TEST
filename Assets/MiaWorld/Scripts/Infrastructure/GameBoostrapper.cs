using UnityEngine;

public class GameBoostrapper : MonoBehaviour
{
    private void Awake()
    {
        var container = new DIContainer();
        var game = new Game(container, this);
    }
}
