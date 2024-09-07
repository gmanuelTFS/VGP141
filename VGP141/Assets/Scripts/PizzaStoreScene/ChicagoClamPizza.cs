using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoClamPizza : Pizza
{
    public ChicagoClamPizza(Dough dough) : base(dough)
    {
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(ChicagoClamPizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(ChicagoClamPizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(ChicagoClamPizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(ChicagoClamPizza)}");
    }
}
