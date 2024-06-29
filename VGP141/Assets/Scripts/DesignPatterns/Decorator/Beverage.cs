using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP23U.DesignPatterns
{
    public abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract float Cost { get; }
    }
}