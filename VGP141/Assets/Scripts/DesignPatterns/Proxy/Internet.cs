using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Internet : MonoBehaviour
{
    public ClientObject ClientObject;
    public ServiceObject ServiceObject;

    private ClientProxy _clientHelper;
    private ServiceProxy _serviceHelper;

    private void Start()
    {
        _clientHelper = new ClientProxy(this, ClientObject);
        _serviceHelper = new ServiceProxy(this, ServiceObject);
        ClientObject.ClientHelper = _clientHelper;
    }

    public void MagicSendToService(string data)
    {
        StartCoroutine(SendServiceDataDelay(1.0f, data));
    }

    public void MagicSendToClient(string data)
    {
        StartCoroutine(SendClientDataDelay(0.5f, data));
    }

    private IEnumerator SendClientDataDelay(float delay, string data)
    {
        yield return new WaitForSeconds(delay);
        _clientHelper.Receive(data);
    }

    private IEnumerator SendServiceDataDelay(float delay, string data)
    {
        yield return new WaitForSeconds(delay);
        _serviceHelper.Receive(data);
    }
}
