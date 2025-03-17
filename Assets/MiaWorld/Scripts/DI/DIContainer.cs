using System;
using System.Collections.Generic;

public class DIContainer
{
    private Dictionary<string, object> _services = new();

    public void Register<T>(T instance) where T : class
    {
        if (_services.ContainsKey(typeof(T).ToString()))
        {
            throw new InvalidOperationException($"Service {typeof(T).Name} registered!");
        }
        
        _services[typeof(T).ToString()] = instance;
    }
    
    public void Register<T>(string key, T instance) where T : class
    {
        if (_services.ContainsKey(typeof(T) + key))
        {
            throw new InvalidOperationException($"Service {typeof(T).Name} with key '{key}' already registered!");
        }
        _services[typeof(T) + key] = instance;
    }

    public T Resolve<T>() where T : class
    {
        return _services.TryGetValue(typeof(T).ToString(), out var service) ? (T)service : null;
    } 
    
    public T Resolve<T>(string key) where T : class
    {
        return _services.TryGetValue(typeof(T) + key, out var service) ? (T)service : null;
    }
}
