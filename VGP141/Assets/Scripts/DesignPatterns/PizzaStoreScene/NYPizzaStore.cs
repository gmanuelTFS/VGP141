using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYPizzaStore : PizzaFactory
{
    private PizzaIngredientFactory _pizzaIngredientFactory;

    public NYPizzaStore()
    {
        _pizzaIngredientFactory = new NYPizzaIngredientFactory();
    }

    public Pizza OrderPizza(string pizzaType)
    {
        Pizza pizza = CreatePizza(pizzaType);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    public override Pizza CreatePizza(string pizzaType)
    {
        switch (pizzaType)
        {
            case "cheese":
                return new NYCheesePizza(_pizzaIngredientFactory.CreateDough());
            case "clam":
                return new NYClamPizza(_pizzaIngredientFactory.CreateDough());
            case "veggie":
                return new NYVeggiePizza(_pizzaIngredientFactory.CreateDough());
            default:
                return null;
        }
    }
}
