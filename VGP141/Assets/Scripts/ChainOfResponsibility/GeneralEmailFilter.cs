using System;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class GeneralEmailFilter : EmailHandler
    {
        public override void HandleEmail(Email pEmail)
        {
            Debug.Log($"Email made it through all filters. Sending to general inbox. {pEmail}");
        }
    }
}
