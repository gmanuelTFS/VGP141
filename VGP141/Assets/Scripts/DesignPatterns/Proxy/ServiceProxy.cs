using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceProxy
{
    public enum ResponseCode
    {
        Success = 0,
        Error_InvalidPlayerId = 1,
    }

    private Internet _internet;
    private ServiceObject _serviceObject;

    public ServiceProxy(Internet internet, ServiceObject serviceObject)
    {
        _internet = internet;
        _serviceObject = serviceObject;
    }

    public void Send(string playerName, DateTime curDateTime)
    {
        // Package up the result data
        ResponseCode responseCode = string.IsNullOrEmpty(playerName)
            ? ResponseCode.Error_InvalidPlayerId : ResponseCode.Success;
        string result = $"{(int)responseCode}|{playerName}|{curDateTime}";

        // Send the result over the internets
        _internet.MagicSendToClient(result);
    }

    public void Receive(string dataPacket)
    {
        // Unpackage the data from the internets
        // FORMAT: $"{playerId}|{curDateTime}"
        string[] splitData = dataPacket.Split('|');
        int.TryParse(splitData[0], out int playerId);
        DateTime.TryParse(splitData[1], out DateTime curDateTime);

        Debug.Log($"Request was received at {curDateTime}.");

        // Send request to the ServiceObject
        string result = _serviceObject.GetPlayerName(playerId);
        Send(result, DateTime.Now);
    }
}
