using System;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class EmailLogger : EmailHandler
    {
        public EmailLogger(EmailHandler nextHandler) : base(nextHandler) { }
        
        public override void HandleEmail(Email pEmail)
        {
            Debug.Log($"Email received at {DateTime.Now}. Sent at {pEmail.SentTimestamp} from {pEmail.Sender} with subject {pEmail.SubjectLine}");
            _nextHandler.HandleEmail(pEmail);
        }
    }
}
