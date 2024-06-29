using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tv
{
    public int CurrentChannel { get; protected set; }

    public abstract void TurnOn();

    public abstract void TurnOff();

    public abstract void TuneChannel(int newChannel);
}
