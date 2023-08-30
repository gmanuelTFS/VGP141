using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PizzaStore
// PizzaFactory
public abstract class Pizza
{
    public Dough Dough { get; }

    public Pizza(Dough dough)
    {
        Dough = dough;
        Debug.Log(Dough.Name);
    }

    public abstract void Prepare();
    public abstract void Bake();
    public abstract void Cut();
    public abstract void Box();
}
