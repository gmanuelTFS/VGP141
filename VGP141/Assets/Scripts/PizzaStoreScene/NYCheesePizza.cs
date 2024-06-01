using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYCheesePizza : Pizza
{
    public NYCheesePizza(Dough dough) : base(dough)
    {
        
    }

    public override void Bake()
    {
        Debug.Log($"Baking {nameof(NYCheesePizza)}");
    }

    public override void Box()
    {
        Debug.Log($"Boxing {nameof(NYCheesePizza)}");
    }

    public override void Cut()
    {
        Debug.Log($"Cutting {nameof(NYCheesePizza)}");
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {nameof(NYCheesePizza)}");
    }
}
