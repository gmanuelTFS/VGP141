using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    private int _framesLeft;
    private Vector2 _velocity;
    private Transform _transform;

    public bool InUse => _framesLeft > 0;

    private void Awake()
    {
        _transform = transform;
        _framesLeft = 0;
        _velocity = Vector2.zero;
    }

    public void Init(float x, float y, float xVel, float yVel, int lifetime)
    {
        _framesLeft = lifetime;
        _transform.position = new Vector3(x, y, 0);
        _velocity.Set(xVel, yVel);
    }

    public void Reset()
    {
        _transform.position = Vector3.zero;
        _velocity.Set(0, 0);
        _framesLeft = 0;
    }

    public bool Animate()
    {
        if (!InUse)
        {
            return false;
        }

        _transform.position = new Vector3(_transform.position.x + _velocity.x, _transform.position.y + _velocity.y, _transform.position.z);
        --_framesLeft;

        return _framesLeft == 0;
    }
}
