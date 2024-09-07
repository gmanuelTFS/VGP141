using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaIngredientFactory
{
    public abstract Dough CreateDough();
    public abstract Cheese CreateCheese();
    public abstract Sauce CreateSauce();
    public abstract Clams CreateClams();
}
