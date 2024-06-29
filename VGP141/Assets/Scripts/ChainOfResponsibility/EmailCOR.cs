using System.Collections;
using System.Collections.Generic;
using ChainOfResponsibility;
using UnityEngine;

public class EmailCOR : MonoBehaviour
{
    private EmailLogger _startOfEmailFilterChain;
    
    // Start is called before the first frame update
    private void Start()
    {
        GeneralEmailFilter generalEmailFilter = new ();
        HrEmailFilter hrEmailFilter = new(generalEmailFilter);
        LegalEmailFilter legalEmailFilter = new(hrEmailFilter);
        JunkEmailFilter junkEmailFilter = new(legalEmailFilter);
        _startOfEmailFilterChain = new EmailLogger(junkEmailFilter);
    }

    public void SendJunkEmail()
    {
        Email junkEmail = new ("callme@junk.com", "Call me and I'll help you win $1,000,000 :D");
        _startOfEmailFilterChain.HandleEmail(junkEmail);
    }

    public void SendLegalEmail()
    {
        Email legalEmail = new ("smartlawyers@legal.com", "We are smarter, dum du dum dum dum.");
        _startOfEmailFilterChain.HandleEmail(legalEmail);
    }

    public void SendHrEmail(bool isComplaintEmail)
    {
        Email hrEmail = new ("callme@hr.com", isComplaintEmail ? "I have a major complaint about paycheques!" : "Question re requesting time off");
        _startOfEmailFilterChain.HandleEmail(hrEmail);
    }

    public void SendGeneralEmail()
    {
        Email generalEmail = new ("iamgreat@wonderbar.com", "You want Wonderbars, I can provide");
        _startOfEmailFilterChain.HandleEmail(generalEmail);
    }
}
