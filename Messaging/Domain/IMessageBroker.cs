using Messaging.Api;

namespace Messaging.Domain;

internal interface IMessageBroker
{
    Task Connect(ConnectionParams connectionParams);
    Task Disconnect();
    Task Query(string topic, object queryDetails); // Change object to a Query type.
    Task Publish(string topic, Message message);
    Task Subscribe(string topic, Action<Message> handler);
    Task Unsubscribe(string topic, Action<Message> handler);
}