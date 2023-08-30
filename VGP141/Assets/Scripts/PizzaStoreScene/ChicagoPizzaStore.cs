using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoPizzaStore : PizzaFactory
{
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
                return new ChicagoCheesePizza(new DeepDishDough());
            case "clam":
                return new ChicagoClamPizza(new DeepDishDough());
            case "veggie":
                return new ChicagoVeggiePizza(new DeepDishDough());
            default:
                return null;
        }
    }
}
