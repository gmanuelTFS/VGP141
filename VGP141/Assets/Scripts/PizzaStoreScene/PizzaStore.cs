using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaStore
{
    protected PizzaFactory _pizzaFactory;

    public PizzaStore(PizzaFactory pizzaFactory)
    {
        _pizzaFactory = pizzaFactory;
    }

    public abstract Pizza OrderPizza(string pizzaType);
}
