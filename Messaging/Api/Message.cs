namespace Messaging.Api;

public class Message
{
    public readonly object? Payload;

    public Message()
    {
    }
    
    public Message(object? payload)
    {
        Payload = payload;
    }

    public override string ToString()
    {
        if (Payload is null)
        {
            return "{}";
        }
        
        return "{" + Payload + "}";
    }
}