using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPizzaOrdering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PizzaFactory nyP = new NYPizzaStore();
        PizzaFactory cP = new ChicagoPizzaStore();

        nyP.CreatePizza("cheese");
        nyP.CreatePizza("clam");
        nyP.CreatePizza("veggie");

        cP.CreatePizza("cheese");
        cP.CreatePizza("clam");
        cP.CreatePizza("veggie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
