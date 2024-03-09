using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceObject : MonoBehaviour
{
    private Dictionary<int, string> _playerInfo;

    public ServiceObject()
    {
        _playerInfo = new Dictionary<int, string>
        {
            { 12345, "Johnny" },
            { 67899, "Jumanji" },
        };
    }

    public string GetPlayerName(int playerId)
    {
        // Pretend that this does a look up in a giant database
        _playerInfo.TryGetValue(playerId, out string playerName);
        return playerName;
    }
}
