using Shared;

namespace Kaizen;

public class ModuleInitializer : IModule
{
    private ModuleInitializer()
    {
    }

    public static void Initialize()
    {
        Messaging.Api.ModuleInitializer.Initialize();
        Logging.Api.ModuleInitializer.Initialize();
    }
}