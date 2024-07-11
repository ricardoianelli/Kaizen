using Messaging.Application;
using Messaging.Domain;

namespace Messaging.Api;

public static class MessageNotifier
{
    public const string GlobalTopic = "global";
    private static IMessageBroker _broker;

    static MessageNotifier()
    {
        _broker = new CSharpMessageBroker();
    }
    
    internal static void SetBroker(IMessageBroker broker)
    {
        _broker = broker;
    }
    
    public static async Task Publish(string topic, object payload)
    {
        var message = new Message(topic, payload);
        await _broker.Publish(topic, message);
        await _broker.Publish(GlobalTopic, message);
    }
    
    public static async Task Subscribe(string topic, Action<object?> handler)
    {
        await _broker.Subscribe(topic, handler);
    }
}