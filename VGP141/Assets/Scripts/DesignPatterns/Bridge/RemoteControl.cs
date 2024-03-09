using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RemoteControl
{
    protected Tv _implementor;

    public virtual void TurnOn()
    {
        _implementor.TurnOn();
    }

    public virtual void TurnOff()
    {
        _implementor.TurnOff();
    }

    public virtual void SetChannel(int newChannel)
    {
        _implementor.TuneChannel(newChannel);
    }
    
    public virtual void NextChannel()
    {
        SetChannel(_implementor.CurrentChannel + 1);
    }

    public virtual void PrevChannel()
    {
        SetChannel(_implementor.CurrentChannel - 1);
    }
}
