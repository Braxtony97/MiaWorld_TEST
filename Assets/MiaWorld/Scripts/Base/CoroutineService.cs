using System.Collections;
using UnityEngine;

public class CoroutineService
{
    private readonly MonoBehaviour _monoBehaviour;

    public CoroutineService(MonoBehaviour monoBehaviour)
    {
        _monoBehaviour = monoBehaviour;
    }

    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return _monoBehaviour.StartCoroutine(routine);
    }

    public void StopCoroutine(IEnumerator coroutine)
    {
        _monoBehaviour.StopCoroutine(coroutine);
    }
}
