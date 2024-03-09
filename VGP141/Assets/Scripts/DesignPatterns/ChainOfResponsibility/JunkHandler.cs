using System;
using UnityEngine;

public class JunkHandler : EmailHandler
{
    public override void HandleEmail(Email email)
    {
        if (email.Subject.Contains("junk", StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log($"Junk email from {email.Sender} is being moved to the junk folder.");
            return;
        }
        
        _successor?.HandleEmail(email);
    }

    public JunkHandler(EmailHandler successor) : base(successor) { }
}
