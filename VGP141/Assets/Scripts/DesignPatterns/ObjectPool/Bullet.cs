using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour, IPoolable
{
    public Action<Bullet> LifetimeComplete;
    [SerializeField] private float _lifetime;

    public Rigidbody Rigidbody { get; private set; }
    
    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    public void Initialize()
    {
        gameObject.SetActive(true);
        
        StartCoroutine(StartLifetimeCountdown());
    }

    public void Fire(Vector3 startPosition, Vector3 velocity)
    {
        Rigidbody.MovePosition(startPosition);
        Rigidbody.velocity = velocity;
    }

    private IEnumerator StartLifetimeCountdown()
    {
        yield return new WaitForSeconds(_lifetime);

        Disable();
        
        LifetimeComplete?.Invoke(this);
    }

    public void Disable()
    {
        Rigidbody.velocity = Vector3.zero;
        gameObject.SetActive(false);
    }
}
