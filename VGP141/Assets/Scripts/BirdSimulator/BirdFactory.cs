using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFactory : MonoBehaviour
{
    public void CreateAflacDuck()
    {
        SpeakStrategy speakStrategy = new AflacQuackSpeakStrategy();
        WalkStrategy walkStrategy = new BirdWalkStrategy();
        FlyStrategy flyStrategy = new CanFlyStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Aflac"));
        bird.name = "Aflac";
        bird.Initialize(speakStrategy, walkStrategy, flyStrategy);
        bird.Speak();
        bird.Walk();
        bird.Fly();
    }

    public void CreateBruceDuck()
    {
        SpeakStrategy speakStrategy = new QuackSpeakStrategy();
        WalkStrategy walkStrategy = new BirdWalkStrategy();
        FlyStrategy flyStrategy = new CanFlyStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Bruce"));
        bird.name = "Bruce";
        bird.Initialize(speakStrategy, walkStrategy, flyStrategy);
        bird.Speak();
        bird.Walk();
        bird.Fly();
    }

    public void CreateTurkey()
    {
        SpeakStrategy speakStrategy = new GobbleSpeakStrategy();
        WalkStrategy walkStrategy = new BirdWalkStrategy();
        FlyStrategy flyStrategy = new CantFlyStrategy();

        Bird bird = Instantiate(Resources.Load<Bird>("Turkey"));
        bird.name = "Turkey";
        bird.Initialize(speakStrategy, walkStrategy, flyStrategy);
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
