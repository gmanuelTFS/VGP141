using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP23U.DesignPatterns
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        public override string Description => _beverage.Description;

        public override float Cost => _beverage.Cost;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}