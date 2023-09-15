using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperPower
{
    public abstract void Activate();

    protected void MovePlayer(Vector3 move)
    {
        Debug.Log($"Moving player by {move}");
    }

    protected void LookL(bool left)
    {
        Debug.Log($"Looking around the {(left ? "left" : "right")} corner.");
    }

    protected void PlaySound(string soundId)
    {
        Debug.Log($"Playing sound with id: {soundId}");
    }
}
