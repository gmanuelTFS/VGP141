using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaFactory
{
    protected PizzaIngredientFactory _pizzaIngredientFactory;
    
    public abstract Pizza CreatePizza(string pizzaType);
}
