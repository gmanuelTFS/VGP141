using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFlyStrategy : FlyStrategy
{
    public override void Fly()
    {
        Debug.Log("Looks into the sky and flaps it's arms longingly.");
    }
}
