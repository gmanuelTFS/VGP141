using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYVeggiePizza : Pizza
{
    public NYVeggiePizza(Dough dough) : base(dough)
    {
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(NYVeggiePizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(NYVeggiePizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(NYVeggiePizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(NYVeggiePizza)}");
    }
}
