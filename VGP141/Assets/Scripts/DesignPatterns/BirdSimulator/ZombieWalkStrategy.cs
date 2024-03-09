using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalkStrategy : WalkStrategy
{
    public override void Walk()
    {
        Debug.Log("Walks forward with zero conscious intent.");
    }
}
