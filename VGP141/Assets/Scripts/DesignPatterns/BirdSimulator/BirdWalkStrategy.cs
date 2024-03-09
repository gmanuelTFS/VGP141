using UnityEngine;

public class BirdWalkStrategy : WalkStrategy
{
    public override void Walk()
    {
        Debug.Log("Walks forward with confidence.");
    }
}
