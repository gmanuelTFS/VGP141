using System;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class HrEmailFilter : EmailHandler
    {
        public override void HandleEmail(Email pEmail)
        {
            bool involvesComplaint = pEmail.SubjectLine.Contains("Complaint", StringComparison.OrdinalIgnoreCase);
            if (pEmail.Sender.EndsWith("hr.com") || involvesComplaint)
            {
                Debug.Log($"Detected HR related email from {pEmail.Sender} with subject {pEmail.SubjectLine}.");
                Debug.Log($"Sending email to HR.");
                if (involvesComplaint)
                {
                    Debug.Log($"Changing email priority to URGENT");
                }
                return;
            }
            
            _nextHandler.HandleEmail(pEmail);
        }

        public HrEmailFilter(EmailHandler nextHandler) : base(nextHandler) { }
    }
}
