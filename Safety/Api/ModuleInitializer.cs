using Safety.Application;
using Shared;

namespace Safety.Api;

public class ModuleInitializer : IModule
{
    private ModuleInitializer()
    {
    }
    
    public static void Initialize()
    {
        EStopManager.Initialize();
    }
}