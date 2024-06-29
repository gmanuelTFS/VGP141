using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class ShopView : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            DarkRoast darkRoast = new DarkRoast();
            Sugar beverageWithSugar = new Sugar(darkRoast);
            Cream beverageWithCream = new Cream(beverageWithSugar);

            Debug.Log($"Beverage Description: {beverageWithCream.Description}");
            Debug.Log($"Beverage Cost: ${beverageWithCream.Cost}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}