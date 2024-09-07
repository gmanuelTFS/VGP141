using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoPizzaStore : PizzaFactory
{
    public ChicagoPizzaStore()
    {
        _pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
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
                return new ChicagoCheesePizza(_pizzaIngredientFactory.CreateDough());
            case "clam":
                return new ChicagoClamPizza(_pizzaIngredientFactory.CreateDough());
            case "veggie":
                return new ChicagoVeggiePizza(_pizzaIngredientFactory.CreateDough());
            default:
                return null;
        }
    }
}
