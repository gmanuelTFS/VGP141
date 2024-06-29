using System;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class LegalEmailFilter : EmailHandler
    {
        public override void HandleEmail(Email pEmail)
        {
            if (pEmail.Sender.EndsWith("legal.com") || pEmail.SubjectLine.Contains("SUE", StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log($"Detected legal related email from {pEmail.Sender} with subject {pEmail.SubjectLine}.");
                Debug.Log($"Sending email to legal.");
                return;
            }
            
            _nextHandler.HandleEmail(pEmail);
        }

        public LegalEmailFilter(EmailHandler nextHandler) : base(nextHandler) { }
    }
}
