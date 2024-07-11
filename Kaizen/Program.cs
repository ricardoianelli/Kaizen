using Messaging.Api;
using Shared.CrossCutting;

namespace Kaizen;

static class Program
{
    public static async Task Main(String[] args)
    {
        ModuleInitializer.Initialize();

        await MessageNotifier.Publish("PositionChanged", new Position(1, 2));
        Console.ReadKey();
    }
}