
using System;
using UnityEngine;

public class LegalHandler : EmailHandler
{
    public LegalHandler(EmailHandler successor) : base(successor) { }
    public override void HandleEmail(Email email)
    {
        if (email.Subject.Contains("suing", StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log($"Sending email from {email.Sender} to the legal department. I'm not getting sued.");
            return;
        }
        
        _successor?.HandleEmail(email);
    }
}