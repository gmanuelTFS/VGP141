using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class Cream : BeverageDecorator
    {
        public override string Description
        {
            get
            {
                string description = $"{base.Description}, with cream";
                return description;
            }
        }

        public override float Cost => base.Cost + 0.40f;

        public Cream(Beverage beverage) : base(beverage)
        {

        }
    }
}