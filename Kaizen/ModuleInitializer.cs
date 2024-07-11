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
        Sensors.Api.ModuleInitializer.Initialize();
        ConveyorBelts.Api.ModuleInitializer.Initialize();
        Safety.Api.ModuleInitializer.Initialize();
    }
}