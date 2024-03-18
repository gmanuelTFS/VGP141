using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool
{
    // total number of bullets needed
    // on init we need to create the bullets and set them all to disabled
    // a way to spawn a bullet
    
    private const int kMaxBulletCount = 12;
    private Bullet[] _bullets = new Bullet[kMaxBulletCount];

    public BulletPool(Bullet prefab)
    {
        for (int i = 0; i < kMaxBulletCount; i++)
        {
            Bullet bullet = Object.Instantiate(prefab);
            bullet.Disable();
            _bullets[i] = bullet;
        }
    }

    public void SpawnBullet(Vector3 position, Vector3 velocity)
    {
        for (int i = 0; i < kMaxBulletCount; i++)
        {
            if (_bullets[i].gameObject.activeInHierarchy)
            {
                continue;
            }
            
            _bullets[i].Initialize();
            _bullets[i].Fire(position, velocity);
            break;
        }
    }
}
