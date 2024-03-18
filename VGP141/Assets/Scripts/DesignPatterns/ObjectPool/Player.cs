using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private float _bulletPower;
    [SerializeField] private float _shootTime = 0.5f;

    private MonoBehaviourObjectPool<Bullet> _bulletPool;
    private float _shootTimer;
    
    // Start is called before the first frame update
    private void Awake()
    {
        Bullet bulletPrefab = Resources.Load<Bullet>("Bullet");
        _bulletPool = new MonoBehaviourObjectPool<Bullet>(bulletPrefab, 12);
    }

    // Update is called once per frame
    void Update()
    {
        if (_shootTimer > 0)
        {
            _shootTimer -= Time.deltaTime;
        }

        if (_shootTimer < 0)
        {
            _shootTimer = 0;
        }
        
        if (Input.GetKey(KeyCode.Space) && _shootTimer == 0)
        {
            _shootTimer = _shootTime;
            Bullet b = _bulletPool.Spawn();
            b.Fire(_bulletSpawnPoint.position, _bulletSpawnPoint.forward * _bulletPower);
        }
    }
}
