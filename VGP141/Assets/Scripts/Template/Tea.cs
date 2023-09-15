using UnityEngine;

public class Tea : BeverageTemplate
{
    public Tea(string name) : base(name)
    {
    }

    protected override void Brew()
    {
        Debug.Log("Steeping tea bag for 3-5 minutes...");
    }

    protected override void PourIntoCup()
    {
        Debug.Log("Pouring into teacup...");
    }

    protected override void AddCondiments()
    {
        Debug.Log("Adding honey...");
    }
}
