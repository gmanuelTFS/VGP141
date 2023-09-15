using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRayVision : SuperPower
{
    public override void Activate()
    {
        LookL(true);
        LookL(false);
        PlaySound("lRayVisionBloop");
    }
}
