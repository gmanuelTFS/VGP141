using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    /*
     * Speak
     * Walk
     * Fly
     */
    private SpeakStrategy _speakStrategy;
    private WalkStrategy _walkStrategy;
    private FlyStrategy _flyStrategy;

    public void Initialize(SpeakStrategy speakStrategy, WalkStrategy walkStrategy, FlyStrategy flyStrategy)
    {
        _speakStrategy = speakStrategy ?? throw new ArgumentNullException(nameof(speakStrategy));
        _walkStrategy = walkStrategy ?? throw new ArgumentNullException(nameof(walkStrategy));
        _flyStrategy = flyStrategy ?? throw new ArgumentNullException(nameof(flyStrategy));
    }

    public void Zombify(SpeakStrategy speakStrategy, WalkStrategy walkStrategy, FlyStrategy flyStrategy)
    {
        _speakStrategy = speakStrategy ?? throw new ArgumentNullException(nameof(speakStrategy));
        _walkStrategy = walkStrategy ?? throw new ArgumentNullException(nameof(walkStrategy));
        _flyStrategy = flyStrategy ?? throw new ArgumentNullException(nameof(flyStrategy));
    }

    public void Speak()
    {
        // invoke our speak strategy
        _speakStrategy?.Speak();
    }

    public void Walk()
    {
        // invoke our walk strategy
        _walkStrategy?.Walk();
    }

    public void Fly()
    {
        // invoke our fly strategy
        _flyStrategy?.Fly();
    }
}
