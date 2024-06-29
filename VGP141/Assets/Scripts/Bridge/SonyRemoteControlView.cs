using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonyRemoteControlView : MonoBehaviour
{
    private RemoteControl _remoteControl;

    private void Awake()
    {
        _remoteControl = new SonyRemoteControl();
    }

    public void TurnOn()
    {
        _remoteControl.TurnOn();
    }

    public void TurnOff()
    {
        _remoteControl.TurnOff();
    }

    public void SetChannel(int newChannel)
    {
        _remoteControl.SetChannel(newChannel);
    }

    public virtual void NextChannel()
    {
        _remoteControl.NextChannel();
    }

    public virtual void PrevChannel()
    {
        _remoteControl.PrevChannel();
    }
}
