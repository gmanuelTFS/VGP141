using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourObjectPool<T> where T : MonoBehaviour, IPoolable
{
    // total number of bullets needed
    // on init we need to create the bullets and set them all to disabled
    // a way to spawn a bullet
    
    private readonly List<T> _objects;

    public MonoBehaviourObjectPool(T prefab, int maxCount)
    {
        _objects = new List<T>(maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            T obj = Object.Instantiate(prefab);
            obj.Disable();
            _objects.Add(obj);
        }
    }

    public T Spawn()
    {
        foreach (T obj in _objects)
        {
            if (obj.gameObject.activeInHierarchy)
            {
                continue;
            }
            
            obj.Initialize();
            return obj;
        }

        return null;
    }
}
