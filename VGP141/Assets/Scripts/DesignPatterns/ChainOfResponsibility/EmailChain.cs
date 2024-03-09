using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailChain : MonoBehaviour
{
    private EmailHandler _firstHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        GeneralHandler generalHandler = new(null);
        LegalHandler legalHandler = new(generalHandler);
        JunkHandler junkHandler = new(legalHandler);
        _firstHandler = new LogHandler(junkHandler);
    }

    private void ReceiveEmail(Email email)
    {
        _firstHandler.HandleEmail(email);
    }

    public void SendEmail()
    {
        Email realEmail = new("realsender@yup.com", DateTime.Now, "Totally Real Email");
        ReceiveEmail(realEmail);
    }

    public void SendJunkEmail()
    {
        Email realEmail = new("junksender@nope.com", DateTime.Now, "Totally Junk Email");
        ReceiveEmail(realEmail);
    }

    public void SendLegalEmail()
    {
        Email realEmail = new("lawyer@yougettingsued.com", DateTime.Now, "I'M SUING YOU");
        ReceiveEmail(realEmail);
    }
}
