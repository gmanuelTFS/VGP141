using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonyTv : Tv
{
    public override void TuneChannel(int newChannel)
    {
        CurrentChannel = newChannel;
        Debug.Log($"Sony Tv tuning to channel {CurrentChannel}...");
    }

    public override void TurnOff()
    {
        Debug.Log("Sony Tv turning off...");
    }

    public override void TurnOn()
    {
        Debug.Log("Sony Tv turning on...");
    }
}
