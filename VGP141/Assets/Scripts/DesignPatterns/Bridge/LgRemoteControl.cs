using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LgRemoteControl : RemoteControl
{
    public LgRemoteControl()
    {
        _implementor = new LgTv();
    }
}
