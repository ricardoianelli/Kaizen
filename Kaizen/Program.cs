using Logging.Api;
using Messaging.Api;
using Shared.CrossCutting;

//var logger = new Logger();
Logger.Log("Test msg 1"); // For this to work I need to call logger first so the static instance is created.

await MessageBroker.Publish("PositionChanged", new Position(1, 2));
Logger.Log("Press any key to finish.");
Console.ReadKey();