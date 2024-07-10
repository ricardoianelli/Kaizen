using System.Text;

namespace Messaging.Api;

public class Message
{
    public readonly MessageType MessageType;
    public readonly object? Payload;

    public Message(MessageType messageType, object? payload)
    {
        MessageType = messageType;
        Payload = payload;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"MessageType: {MessageType}");
        if (Payload != null)
        {
            sb.Append($" - Payload: {Payload}");
        }

        return sb.ToString();
    }
}