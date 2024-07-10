namespace Messaging.Api;

public class Message
{
    public MessageType MessageType;
    public object? Payload;

    public Message(MessageType messageType, object? payload)
    {
        MessageType = messageType;
        Payload = payload;
    }
}