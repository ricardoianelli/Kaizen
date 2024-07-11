using Messaging.Api;

namespace Messaging.Domain;

internal interface IMessageBroker
{
    Task Connect(BrokerConnectionParams brokerConnectionParams);
    Task Disconnect();
    Task Publish(string topic, Message message);
    Task Subscribe(string topic, Action<Message> handler);
    Task Unsubscribe(string topic, Action<Message> handler);
}