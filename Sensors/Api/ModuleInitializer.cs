using Sensors.Application;
using Shared;

namespace Sensors.Api;

public class ModuleInitializer : IModule
{
    private ModuleInitializer()
    {
    }
    
    public static void Initialize()
    {
        SensorManager.Initialize();
    }
}