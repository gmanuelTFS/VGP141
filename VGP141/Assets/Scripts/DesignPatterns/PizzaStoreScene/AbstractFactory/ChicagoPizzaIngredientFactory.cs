using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
    public override Cheese CreateCheese()
    {
        throw new System.NotImplementedException();
    }

    public override Clams CreateClams()
    {
        throw new System.NotImplementedException();
    }

    public override Dough CreateDough()
    {
        return new DeepDishDough();
    }

    public override Sauce CreateSauce()
    {
        throw new System.NotImplementedException();
    }
}
