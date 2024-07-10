using Messaging.Application;
using Messaging.Domain;

namespace Messaging.Api;

public static class MessageBroker
{
    private static IMessageBroker _broker;

    static MessageBroker()
    {
        _broker = new CSharpMessageBroker();
    }
    
    internal static void SetBroker(IMessageBroker broker)
    {
        _broker = broker;
    }
    
    public static async Task Publish(string topic, Message message)
    {
        await _broker.Publish(topic, message);
    }
    
    public static async Task Subscribe(string topic, Action<Message> handler)
    {
        await _broker.Subscribe(topic, handler);
    }
}