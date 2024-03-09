using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFactory : MonoBehaviour
{
    private readonly WalkStrategy _birdWalkStrategy = new BirdWalkStrategy();
    private readonly FlyStrategy _canFlyStrategy = new CanFlyStrategy();
    public void CreateAflacDuck()
    {
        SpeakStrategy speakStrategy = new AflacQuackSpeakStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Aflac"));
        bird.name = "Aflac";
        bird.Initialize(speakStrategy, _birdWalkStrategy, _canFlyStrategy);
        bird.Speak();
        bird.Walk();
        bird.Fly();
    }

    public void CreateBruceDuck()
    {
        SpeakStrategy speakStrategy = new QuackSpeakStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Bruce"));
        bird.name = "Bruce";
        bird.Initialize(speakStrategy, _birdWalkStrategy, _canFlyStrategy);
        bird.Speak();
        bird.Walk();
        bird.Fly();
    }

    public void CreateTurkey()
    {
        SpeakStrategy speakStrategy = new GobbleSpeakStrategy();
        FlyStrategy flyStrategy = new CantFlyStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Turkey"));
        bird.name = "Turkey";
        bird.Initialize(speakStrategy, _birdWalkStrategy, flyStrategy);
        bird.Speak();
        bird.Walk();
        bird.Fly();
    }

    public void ChangeBruceIntoAZombie()
    {
        Bird bruce = GameObject.Find("Bruce").GetComponent<Bird>();
        bruce.Zombify(new ZombieQuackStrategy(), new ZombieWalkStrategy(), new ZombieFlyStrategy());
        bruce.name = "Zombie Bruce";
        bruce.Speak();
        bruce.Walk();
        bruce.Fly();
    }
}
