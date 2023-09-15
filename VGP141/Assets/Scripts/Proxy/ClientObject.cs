using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClientObject : MonoBehaviour
{
    public TextMeshProUGUI PlayerName;
    public ClientProxy ClientHelper;

    public void RequestPlayerName(int playerId)
    {
        ClientHelper.Send(playerId, DateTime.Now);
    }

    public void ShowPlayerName(string playerName)
    {
        PlayerName.text = playerName;
    }
}
