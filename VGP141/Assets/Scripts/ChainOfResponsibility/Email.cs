using System;

namespace ChainOfResponsibility
{
    public class Email
    {
        public string Sender { get; }
        public string SubjectLine { get; }
        public DateTime SentTimestamp { get; }

        public Email(string pSender, string pSubjectLine)
        {
            Sender = pSender;
            SubjectLine = pSubjectLine;
            SentTimestamp = DateTime.Now;
        }

        public override string ToString() => $"From: {Sender}, Subject: {SubjectLine}, Sent: {SentTimestamp}";
    }
}
