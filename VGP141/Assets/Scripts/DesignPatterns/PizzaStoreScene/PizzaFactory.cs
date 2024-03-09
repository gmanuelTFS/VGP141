using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaFactory
{
    public abstract Pizza CreatePizza(string pizzaType);
}
