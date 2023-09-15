using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourOver : BeverageTemplate
{
    public PourOver(string name) : base(name)
    {
    }

    protected override void Brew()
    {
        Debug.Log("Pouring water over coffee grounds...");
    }

    protected override void PourIntoCup()
    {
        
    }

    protected override void AddCondiments()
    {
        Debug.Log("Adding cream and sugar...");
    }
}
