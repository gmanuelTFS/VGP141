using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class DarkRoast : Beverage
    {
        public override string Description => "Dark Roast";

        public override float Cost => 1.0f;
    }
}