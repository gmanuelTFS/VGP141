using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePool : MonoBehaviour
{
    private const int MAX_PARTICLES = 100;
    private Particle[] _particles;

    public Particle ParticlePrefab;

    private void Awake()
    {
        _particles = new Particle[MAX_PARTICLES];

        for (int i = 0; i < MAX_PARTICLES; i++)
        {
            _particles[i] = Instantiate(ParticlePrefab, Vector3.zero, Quaternion.identity, transform);
            _particles[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            Create(0, 0, -5 * Time.deltaTime, 0, 500);
        }

        foreach (Particle particle in _particles)
        {
            if (particle.Animate())
            {
                particle.gameObject.SetActive(false);
                particle.Reset();
            }
        }
    }

    public void Create(float x, float y, float xVel, float yVel, int lifetime)
    {
        for (int i = 0; i < MAX_PARTICLES; i++)
        {
            if (!_particles[i].InUse)
            {
                _particles[i].Init(x, y, xVel, yVel, lifetime);
                _particles[i].gameObject.SetActive(true);
                break;
            }
        }
    }
}
