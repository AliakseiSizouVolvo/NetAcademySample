namespace Generics;

public class Message
{
    public string Text { get;}

    public Message(string text)
    {
        Text = text;
    }

    public string Format()
    {
        return $"Hello. {Text}"; 
    }
}

public class EmailMessage : Message
{
    public EmailMessage(string text) : base(text)
    {
    }

    public new string Format()
    {
        return $"Hello.{Environment.NewLine}{Text}";
    }
}

public class SmsMessage : Message
{
    public SmsMessage(string text) : base(text)
    {
    }
}


public class MessageSender 
{
    public void SendMessage<T>(T message) 
        where T : Message
    {
        Console.WriteLine(message.Format());    
    }
}