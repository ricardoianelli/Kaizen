 

using Logging.Api;
using Messaging.Api;

//var logger = new Logger();
Logger.Log("Test msg 1"); // For this to work I need to call logger first so the static instance is created.

var msg = new Message(MessageType.MaterialPickupRequest, "(X:1, Y:0)");
await MessageBroker.Publish("global", msg);
Logger.Log("Test msg 2");
Console.ReadKey();