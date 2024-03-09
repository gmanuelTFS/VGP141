using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EmailHandler
{
    protected EmailHandler _successor;

    public EmailHandler(EmailHandler successor)
    {
        _successor = successor;
    }
    public abstract void HandleEmail(Email email);
}
