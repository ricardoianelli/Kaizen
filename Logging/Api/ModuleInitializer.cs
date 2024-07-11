using Shared;

namespace Logging.Api;

public class ModuleInitializer : IModule
{
    public static void Initialize()
    {
        Logger.Log("Logging module loaded.");
    }
}