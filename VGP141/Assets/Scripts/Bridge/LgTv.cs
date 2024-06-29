using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LgTv : Tv
{
    public override void TuneChannel(int newChannel)
    {
        CurrentChannel = newChannel;
        Debug.Log($"LG Tv tuning to channel {CurrentChannel}...");
    }

    public override void TurnOff()
    {
        Debug.Log("LG Tv turning off...");
    }

    public override void TurnOn()
    {
        Debug.Log("LG Tv turning on...");
    }
}