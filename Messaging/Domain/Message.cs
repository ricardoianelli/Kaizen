using Newtonsoft.Json;

namespace Messaging.Domain;

internal class Message
{
    public readonly string Topic;
    public readonly object? Payload;
    
    public Message(string topic, object? payload)
    {
        Topic = topic;
        Payload = payload;
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}