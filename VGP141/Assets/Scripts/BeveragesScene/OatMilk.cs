using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class OatMilk : BeverageDecorator
    {
        public override string Description
        {
            get
            {
                string description = $"{base.Description}, with oat milk";
                return description;
            }
        }

        public override float Cost => base.Cost + 0.50f;

        public OatMilk(Beverage beverage) : base(beverage)
        {
        }
    }
}