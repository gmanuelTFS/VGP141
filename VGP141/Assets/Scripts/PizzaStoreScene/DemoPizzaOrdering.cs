using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPizzaOrdering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NYPizzaStore nyP = new NYPizzaStore();
        ChicagoPizzaStore cP = new ChicagoPizzaStore();

        nyP.OrderPizza("cheese");
        nyP.OrderPizza("clam");
        nyP.OrderPizza("veggie");

        cP.OrderPizza("cheese");
        cP.OrderPizza("clam");
        cP.OrderPizza("veggie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
