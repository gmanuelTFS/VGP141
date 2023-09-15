using UnityEngine;

public class CantFlyStrategy : FlyStrategy
{
    public override void Fly()
    {
        Debug.Log("Looks into the sky longingly.");
    }
}
