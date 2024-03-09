using System;

public class Email
{
    public string Sender { get; }
    public DateTime Timestamp  { get; }
    public string Subject { get; }

    public Email(string sender, DateTime timestamp, string subject)
    {
        Sender = sender;
        Timestamp = timestamp;
        Subject = subject;
    }

    public override string ToString()
    {
        return $"{nameof(Sender)}: {Sender} | {nameof(Timestamp)}: {Timestamp} | {nameof(Subject)}: {Subject}";
    }
}
