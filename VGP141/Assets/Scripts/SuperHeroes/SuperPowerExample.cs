using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPowerExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SuperPower lRayVision = new LRayVision();
        SuperPower footLongFly = new FootLongFly();
        lRayVision.Activate();
        footLongFly.Activate();
    }
}
