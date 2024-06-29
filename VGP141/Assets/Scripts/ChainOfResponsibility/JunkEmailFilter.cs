using UnityEngine;

namespace ChainOfResponsibility
{
    public class JunkEmailFilter : EmailHandler
    {
        public override void HandleEmail(Email pEmail)
        {
            if (pEmail.Sender.EndsWith("junk.com"))
            {
                Debug.Log($"Detected junk email from {pEmail.Sender} with subject {pEmail.SubjectLine}");
                Debug.Log($"Sending email to junk folder.");
                return;
            }
            
            _nextHandler.HandleEmail(pEmail);
        }

        public JunkEmailFilter(EmailHandler nextHandler) : base(nextHandler) { }
    }
}
