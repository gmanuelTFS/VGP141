using UnityEngine;

public abstract class BeverageTemplate
{
    public string Name { get; }

    public BeverageTemplate(string name)
    {
        Name = name;
    }

    public void Prepare()
    {
        Debug.Log($"Preparing {Name}...");
        BoilWater();
        Brew();
        PourIntoCup();
        AddCondiments();
        Debug.Log($"Enjoy {Name}!");
    }

    protected virtual void BoilWater()
    {
        Debug.Log("Boiling water...");
    }

    protected virtual void Brew()
    {
        Debug.Log("Brewing...");
    }

    protected virtual void PourIntoCup()
    {
        Debug.Log("Pouring into cup...");
    }

    protected virtual void AddCondiments()
    {
        Debug.Log("Adding Condiments...");
    }
}
