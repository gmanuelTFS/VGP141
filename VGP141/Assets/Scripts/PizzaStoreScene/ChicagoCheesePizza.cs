using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoCheesePizza : Pizza
{
    public ChicagoCheesePizza(Dough dough) : base(dough)
    {
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(ChicagoCheesePizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(ChicagoCheesePizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(ChicagoCheesePizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(ChicagoCheesePizza)}");
    }
}
