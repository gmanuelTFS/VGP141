using UnityEngine;

public class CanFlyStrategy : FlyStrategy
{
    public override void Fly()
    {
        Debug.Log("Flies up into the sky.");
    }
}
