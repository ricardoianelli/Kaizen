using Logging.Api;
using Messaging.Api;
using Shared.CrossCutting;

namespace Kaizen;

static class Program
{
    public static async Task Main(String[] args)
    {
        ModuleInitializer.Initialize();

        await MessageBroker.Publish("PositionChanged", new Position(1, 2));
        Logger.Log("Press any key to finish.");
        Console.ReadKey();
    }
}