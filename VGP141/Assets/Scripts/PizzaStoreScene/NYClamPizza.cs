using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYClamPizza : Pizza
{
    public NYClamPizza(Dough dough) : base(dough)
    {
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(NYClamPizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(NYClamPizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(NYClamPizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(NYClamPizza)}");
    }
}
