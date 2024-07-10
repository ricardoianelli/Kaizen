using Messaging.Application;
using Messaging.Domain;

namespace Messaging.Api;

public static class Messaging
{
    private static IMessageBroker _messageBroker;

    static Messaging()
    {
        _messageBroker = new CSharpMessageBroker();
    }
    
    internal static void SetBroker(IMessageBroker broker)
    {
        _messageBroker = broker;
    }
    
    public static async Task Publish(string topic, Message message)
    {
        await _messageBroker.Publish(topic, message);
    }
    
    public static async Task Subscribe(string topic, Action<Message> handler)
    {
        await _messageBroker.Subscribe(topic, handler);
    }
}