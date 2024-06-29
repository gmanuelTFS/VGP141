using UnityEngine;

public class QuackSpeakStrategy : SpeakStrategy
{
    public override void Speak()
    {
        Debug.Log("Quack quack.");
    }
}
