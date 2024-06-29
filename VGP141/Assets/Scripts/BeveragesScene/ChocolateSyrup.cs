using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class ChocolateSyrup : BeverageDecorator
    {
        public override string Description
        {
            get
            {
                string description = $"{base.Description}, with chocolate syrup";
                return description;
            }
        }

        public override float Cost => base.Cost + 0.95f;

        public ChocolateSyrup(Beverage beverage) : base(beverage)
        { 
        
        }
    }
}