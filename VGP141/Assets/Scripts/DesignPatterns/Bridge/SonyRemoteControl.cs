using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonyRemoteControl : RemoteControl
{
    public SonyRemoteControl()
    {
        _implementor = new SonyTv();
    }
}
