using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class Sugar : BeverageDecorator
    {
        public override string Description
        {
            get
            {
                string description = $"{base.Description}, with sugar";
                return description;
            }
        }

        public override float Cost => base.Cost + 0.25f;

        public Sugar(Beverage decoratedComponent) : base(decoratedComponent)
        {
        }
    }
}