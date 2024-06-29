using System.Collections;
using System.Collections.Generic;
using Momento;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player Player;

    private PlayerMomento _latestPlayerMomento;
    
    public void CreatePlayerMomento()
    {
        _latestPlayerMomento = Player.CreateMomento();
    }

    public void RestorePlayer()
    {
        Player.SetMomento(_latestPlayerMomento);
    }
}
