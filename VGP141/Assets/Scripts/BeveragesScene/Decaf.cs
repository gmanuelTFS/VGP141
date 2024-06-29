using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class Decaf : Beverage
    {
        public override string Description => "Decaf";

        public override float Cost => 0.90f;
    }
}