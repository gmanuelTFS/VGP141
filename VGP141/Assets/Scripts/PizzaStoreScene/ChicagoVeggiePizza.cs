using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoVeggiePizza : Pizza
{
    public ChicagoVeggiePizza(Dough dough) : base(dough)
    {
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(ChicagoVeggiePizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(ChicagoVeggiePizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(ChicagoVeggiePizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(ChicagoVeggiePizza)}");
    }
}
