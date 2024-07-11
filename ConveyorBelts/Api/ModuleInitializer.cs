using ConveyorBelts.Application;
using Shared;

namespace ConveyorBelts.Api;

public class ModuleInitializer : IModule
{
    private ModuleInitializer()
    {
    }
    
    public static void Initialize()
    {
        ConveyorBeltsManager.Initialize();
    }
}