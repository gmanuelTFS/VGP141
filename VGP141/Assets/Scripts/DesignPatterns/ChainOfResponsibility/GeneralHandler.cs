using UnityEngine;

public class GeneralHandler : EmailHandler
{
    public override void HandleEmail(Email email)
    {
        Debug.Log($"Sending email from {email.Sender} to general inbox.");
        _successor?.HandleEmail(email);
    }

    public GeneralHandler(EmailHandler successor) : base(successor) { }
}