using UnityEngine;

public class LogHandler : EmailHandler
{
    public override void HandleEmail(Email email)
    {
        Debug.Log(email);
        _successor?.HandleEmail(email);
    }

    public LogHandler(EmailHandler successor) : base(successor) { }
}