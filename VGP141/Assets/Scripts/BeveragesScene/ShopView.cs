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
            Sugar sugar = new Sugar(darkRoast);
            Cream cream = new Cream(sugar);

            Debug.Log($"Beverage Description: {cream.Description}");
            Debug.Log($"Beverage Cost: ${cream.Cost}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}