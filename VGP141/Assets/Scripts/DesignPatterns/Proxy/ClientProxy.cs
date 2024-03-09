using System;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class ClientProxy
{
    public enum ResponseCode
    {
        Success = 0,
        InvalidPlayerId = 1,
    }

    private Internet _internet;
    private ClientObject _clientObject;

    public ClientProxy(Internet internet, ClientObject clientObject)
    {
        _internet = internet;
        _clientObject = clientObject;
    }

    public void Send(int playerId, DateTime curDateTime)
    {
        // Package up the request data
        string requestData = $"{playerId}|{curDateTime}";

        // Send the request over the internets
        _internet.MagicSendToService(requestData);
    }

    public void Receive(string dataPacket)
    {
        // Unpackage the data from the internets
        // FORMAT: $"{(int)responseCode}|{playerName}|{curDateTime}"
        string[] results = dataPacket.Split('|');
        Enum.TryParse(results[0], out ResponseCode responseCode);
        string playerName = results[1];
        DateTime.TryParse(results[2], out DateTime curDateTime);

        Debug.Log($"Result received at {curDateTime}.");

        // Give result back to ClientObject
        switch (responseCode)
        {
            case ResponseCode.Success:
                _clientObject.ShowPlayerName(playerName);
                break;
            case ResponseCode.InvalidPlayerId:
                Debug.LogError($"Request was not successful. Reponse Code {responseCode} was returned.");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(responseCode));
        }
    }
}
